using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CSharp.ExpressionTree
{
    public class ExpressionTree
    {
        public Expression<Func<int, int, int>> expression;

        public int Add(int x, int y)
        {
            Expression<Func<int, int, int>> expressionTree = (num1, num2) => num1 + num2;

            Func<int, int, int> func = expressionTree.Compile();
            return func(x, y);
        }

        public int Multiply(int x, int y)
        {
            ConstantExpression left = Expression.Constant(x);
            ConstantExpression right = Expression.Constant(y);
            BinaryExpression binaryExpression = Expression.Multiply(left, right);
            Expression<Func<int>> lambdaExpression = Expression.Lambda<Func<int>>(binaryExpression);

            int ans = lambdaExpression.Compile()();
            return ans;
        }

        public bool GetTeenStudent(Student student)
        {
            Expression<Func<Student, bool>> isTeen = student => student.Age > 12 && student.Age < 20;
            var func = isTeen.Compile();
            return func(student);
        }
        public bool GetTeenStudentV2(Student student)
        {
            ParameterExpression pe = Expression.Parameter(typeof(Student), "s");
            var a= Expression.Lambda<Func<Student, bool>>(
                Expression.AndAlso(
                    Expression.GreaterThan(Expression.Property(pe, "Age"), Expression.Constant(12, typeof(int))),
                    Expression.LessThan(Expression.Property(pe, "Age"), Expression.Constant(20, typeof(int)))), 
                    new[] { pe });
            var b = a.Compile();
            return b(student);
        }
    }

    public class Student
    {
        public int Age { get; set; }
    }
}

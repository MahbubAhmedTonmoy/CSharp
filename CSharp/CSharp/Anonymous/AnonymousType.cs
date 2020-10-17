using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp.Anonymous
{
    public class AnonymousType
    {
        public object CreateAnonymousStudent(string id, string name)
        {
            var student = new
            {
                Id = id,
                Name = name
            };
            return student;
        }

        public int ExtractAnonymousStudentId(object student)
        {
            dynamic localStudent = student;
            int studentId = localStudent.Id;
            return studentId;
        }

        public int ExtractAnonymousStudentIdV2(object student)
        {
            object studentId = student.GetType().GetProperty("Id").GetValue(student);
            return (int)studentId;
        }
    }
}

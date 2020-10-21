using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DynamicType
{
    /// <summary>
    /// dynamic type is a type that can avoid COMPILE time checking
    /// it resolve at runtime. so all exception is thrown at runtime
    /// c# version 4
    /// It is diffenet from object type as well. Object type has boxing and unboxing. So it is slow. But dynamic is fast.
    /// </summary>
    public class DynamicType
    {
        public dynamic CreateDynamicEmployee(int id, string name, DateTime dob)
        {
            var employee = new Employee
            {
                Id = id,
                Name = name
            };
            dynamic dynamicEmployee = employee;
            dynamicEmployee.DateOfBirth = dob; //once it assigned can not be added diffent property
            return dynamicEmployee;
        }

        public Employee Transform(dynamic employee)
        {
            var emp = new Employee { Id = employee.Id, DateOfBirth = employee.DateOfBirth, Name = employee.Name };
            return emp;
        }
        public Employee TransformV2(dynamic employee)
        {
            Employee emp = employee;
            return emp;
        }
        public int GetSalary(dynamic employee)
        {
            int salary = employee.GetEmployeeSalary(10);

            return salary;
        }

        public int GetAge(int employeeId)
        {
            return employeeId / 4;
        }

        public int GetAge(dynamic employeeId)
        {
            return employeeId / 4;
        }

        public bool IsDynamicObjectEmployeeType(dynamic employee)
        {
            Type type = employee.GetType();

            return type.Name.Equals("Employee");
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int GetEmployeeSalary(int taxAmount)
        {
            return 100 + taxAmount;
        }
    }
}

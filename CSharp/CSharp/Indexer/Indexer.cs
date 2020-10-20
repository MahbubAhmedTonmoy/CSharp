using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Indexer
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Indexer
    {
        private readonly Student student = new Student { Id = 100, Name = "student" };

        public string this[string index]
        {
            get
            {
                if(index == "Id") { return student.Id.ToString(); }
                if(index == "Name") { return student.Name; }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index == "Id") { student.Id = Convert.ToInt32(value); }
                if (index == "Name") { student.Name = value; }
                throw new IndexOutOfRangeException();
            }
        }

        //list
        public readonly List<Student> studentSet = new List<Student> { new Student { Id = 101, Name = "student1" },
         new Student { Id = 102, Name = "student2" }, new Student { Id = 103, Name = "student3" },
            new Student { Id = 104, Name = "student4" },};

        public Student this[int index]
        {
            get
            {
                Student student = studentSet[index];
                return student;
            }
            set
            {
                studentSet[index] = value;
                throw new IndexOutOfRangeException();
            }
        }
    }
}

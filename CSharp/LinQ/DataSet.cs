using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class DataSet
    {
        public IList<Student> dataset()
        {
            var data = new List<Student>
            {
                { new Student{ Id= 1, PhoneNumber= new List<string>{ "00","11"}, Name ="Mahbub", Age= 25, Remarks = new ArrayList(){ 1,2 } } },
                { new Student{ Id= 2,PhoneNumber= new List<string>{ "22","33"}, Name ="Tonmoy", Age= 23, Remarks = new ArrayList(){ "abc","def"} } },
                { new Student{ Id= 3,PhoneNumber= new List<string>{ "44","55"}, Name ="Tonni", Age= 28, Remarks = new ArrayList(){ "abc", "ghr"}} },
                 { new Student{ Id= 4,PhoneNumber= new List<string>{ "66","77"}, Name ="Utshob ", Age= 24} },
                { new Student{ Id= 5,PhoneNumber= new List<string>{ "123","100"}, Name ="Anik", Age= 23} },
                { new Student{ Id= 6,PhoneNumber= new List<string>{ "0017","011"}, Name ="Badhon", Age= 28, Remarks = new ArrayList(){ 10,20}} },
            };
            return data;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ArrayList Remarks { get; set; } = new ArrayList();
        public List<String> PhoneNumber { get; set; } = new List<string>();
    }
    public class Fruit
    {
        public int Id { get; set; }
    }
}

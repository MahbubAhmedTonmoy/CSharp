using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharp.PatternMatching
{
    public class StudentBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class FullTimeStudent: StudentBase
    {

    }
    public class PartTimeStudent : StudentBase
    {
        public int Age { get; set; }
    }

    public class PatternMatching
    {
        /// <summary>
        /// Pattern matching by is operator
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        
        public bool IsFullTimeStudent(object student)
        {
            return student is FullTimeStudent;
        }

        public string FindCountryName(string countryCode)
        {
            string countryName = countryCode switch
            {
                "bd" => "Bangladesh",
                "in" => "India",
                _ => string.Empty
            };
            return countryName;
        }

        public int CalculatePoint(object student)
        {
            int point = student switch
            {
                object std when std is FullTimeStudent => 200,
                object std when std is PartTimeStudent => 100,
                _ => 0
            };
            return point;
        }
    }
}

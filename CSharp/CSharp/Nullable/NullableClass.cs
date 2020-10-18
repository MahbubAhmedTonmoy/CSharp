using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Nullable
{
    public class NullableClass
    {
        private int? age = null; // assign null

        public int GetAge()
        {
            int getAge = age ?? -1; // null to non-null ??
            return getAge;
        }
        public int? SetAge(int? age)
        {
            this.age = age;
            return this.age;
        }

        public bool IsAgeGreaterThen50(int? age)
        {
            if(age.HasValue && age > 50) { return true; }
            return false;
        }
    }
}

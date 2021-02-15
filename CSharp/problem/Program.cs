using System;
using System.Collections.Generic;
using System.Linq;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 8*((double)40 / (double)100);
            int size =(int)(Math.Floor(d));
            var pass = GeneratePassword(true, true, true, true, 8);
            Console.WriteLine(pass);

        }
        public static string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
            int passwordSize)
        {
            const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
            const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "123456789";
            const string SPECIALS = @"!@£$%^&*()#€";

            char[] password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();
            if (useLowercase) charSet += LOWER_CASE;
            if (useUppercase) charSet += UPPER_CAES;
            if (useNumbers) charSet += NUMBERS;
            if (useSpecial) charSet += SPECIALS;

            for (int count = 0; count < passwordSize; count++)
            {
                password[count] = charSet[_random.Next(charSet.Length - 1)];
            }
            return String.Join(null, password);
        }
    }
}

//[  //List<int> numbers = new List<int>();// { 1, 4, 5, 1, 2, 7, 8, 1, 2, 3 };
            //string x;
            //for(int i = 0; i < 10; i++)
            //{
            //    string userValue = Console.ReadLine();
            //    numbers.Add(Convert.ToInt32(userValue));
            //}
            //var nth = Convert.ToInt32(Console.ReadLine());
            //Dictionary<int, int> track = new Dictionary<int, int>();
            //foreach(var i in numbers)
            //{
            //    if (!track.ContainsKey(i))
            //    {
            //        track.Add(i, 1);
            //    }
            //    else
            //    {
            //        track[i] += 1;
            //    }
            //}
            //var ans = track.FirstOrDefault(x => x.Value == nth).Key;
//]
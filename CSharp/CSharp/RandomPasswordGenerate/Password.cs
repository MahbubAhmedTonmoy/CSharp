using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RandomPasswordGenerate
{
    public class Password
    {
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";

        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
        int passwordSize)
        {
            char[] password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();
            if (useLowercase) charSet += LOWER_CASE;
            if (useUppercase) charSet += UPPER_CAES;
            if (useNumbers) charSet += NUMBERS;
            if (useSpecial) charSet += SPECIALS;

            for(int count=0; count<passwordSize; count++)
            {
                password[count] = charSet[_random.Next(charSet.Length - 1)];
            }
            return String.Join(null, password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Helper
{
    public class PasswordHelper
    {
        public static string GeneratePassword(int PasswordLength)
        {
            string pass = "abcdefghijklmnopqrstuvwxyz123456789";
            Random randNum = new Random();
            char[] MyPass = new char[PasswordLength];
            for (int i = 0; i < PasswordLength; i++)
            {
                MyPass[i] = pass[(int)(35 * randNum.NextDouble())];
            }
            return new string(MyPass);
        }
    }
}

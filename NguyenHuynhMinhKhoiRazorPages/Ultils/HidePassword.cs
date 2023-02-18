using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHuynhMinhKhoiRazorPages.Ultils
{
    public class HidePassword
    {
        public string NotShowPassword(string password)
        {
            int count = 0;
            string result = "";
            foreach (char c in password)
            {
                    count++;
            }
            for(int i = 0; i < count; i++)
            {
                result += "*";
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NguyenHuynhMinhKhoiRazorPages.Validation
{
    public class DataValidation
    {
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public bool IsValidFormatCustomerId(String id)
        {
            string pattern = @"^C";
            Regex re = new Regex(pattern);

            if (re.IsMatch(id))
                return (true);
            else
                return (false);
        }

        public bool IsNumber(String num)
        {
            int n;
            return int.TryParse(num, out n);
        }
    }
}

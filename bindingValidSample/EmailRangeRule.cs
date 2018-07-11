using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace bindingValidSample
{
     public class EmailRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string email;
            Regex _regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            try
            {
                if (((string)value).Length > 0)
                    email = (string)value;
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }

            // Email condition
            //Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            //return regex.IsMatch(s);
            if (!_regex.IsMatch((string)value))
            {
                return new ValidationResult(false, "Please enter a valid email address.");
            }

            return new ValidationResult(true, null);
        }
    }
}

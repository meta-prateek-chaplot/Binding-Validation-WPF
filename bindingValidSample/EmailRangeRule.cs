using System;
using System.Globalization;
using System.Windows.Controls;

namespace bindingValidSample
{
     public class EmailRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string email;
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

            return new ValidationResult(true, null);
        }
    }
}

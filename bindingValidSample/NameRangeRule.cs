using System;
using System.Globalization;
using System.Windows.Controls;

namespace bindingValidSample
{
    public class NameRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name;
            try
            {
                if (((string)value).Length > 0)
                    name = (string)value;
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }

            // Name condition

            return new ValidationResult(true, null);
        }
    }
}

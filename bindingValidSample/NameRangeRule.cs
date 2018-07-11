using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace bindingValidSample
{
    public class NameRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name;
            Regex _regex = new Regex(@"^[a-zA-Z\s]+$");

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
            if (!_regex.IsMatch((string)value))
            {
                return new ValidationResult(false, "Please enter a valid name.");
            }

            return new ValidationResult(true, null);
        }
    }
}

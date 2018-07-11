using System;
using System.Globalization;
using System.Windows.Controls;

namespace bindingValidSample
{
    public class PhoneRangeRule : ValidationRule
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double phone = 0;

            try
            {
                if (((string)value).Length > 0)
                    phone = double.Parse((string)value);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }

            // Phone condition
            if ((phone < Min) || (phone > Max))
            {
                return new ValidationResult(false,
                    "Please enter a valid phone number.");
            }
            return new ValidationResult(true, null);
        }
    }
}

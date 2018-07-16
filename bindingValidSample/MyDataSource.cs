using System;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace bindingValidSample
{
    public class MyDataSource
    {
        [NotNullValidator]
        public string name { get; set; }

        [NotNullValidator]
        public string email { get; set; }

        [NotNullValidator]
        public string phone { get; set; }

        public MyDataSource()
        {
        }
    }
}

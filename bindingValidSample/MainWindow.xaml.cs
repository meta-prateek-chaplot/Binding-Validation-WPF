// remove trigger in event and declare in style triggers : make submit button disabled@start and enabled iff no error in textbox
// use inbuilt validations for rangerules
// get familiar with culture info
// exception handling

using System.Windows;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace bindingValidSample
{
    public partial class MainWindow : Window
    {
        private MyDataSource _dataSource = new MyDataSource();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _dataSource;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // validation testing
            Validator validator = ValidationFactory.CreateValidator<MyDataSource>();
            ValidationResults results = new ValidationResults();
            validator.Validate(_dataSource, results);

            MessageBox.Show("Is _datasource valid? " + results.IsValid.ToString());

            // Providing data to View Details
            displayname.Text = _dataSource.name;
            displayemail.Text = _dataSource.email;
            displayphone.Text = _dataSource.phone;
        }
    }
}

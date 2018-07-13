// make local variable to be binded not other way around
// remove trigger in event and declare in style triggers : make submit button disabled@start and enabled iff no error in textbox
// use inbuilt validations for rangerules
// exception handling

using System.Windows;

namespace bindingValidSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MyDataSource mds = (MyDataSource)this.TryFindResource("Ods");
            
            // Providing data to View Details
            displayname.Text = mds.name;
            displayemail.Text = mds.email;
            displayphone.Text = mds.phone;
        }
    }
}

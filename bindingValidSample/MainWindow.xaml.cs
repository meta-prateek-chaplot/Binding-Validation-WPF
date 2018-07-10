using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bindingValidSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string objName;
        string objEmail;
        string objPhone;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Fetching data from Entry Details
            objName = name.Text;
            objEmail = email.Text;
            objPhone = phone.Text;

            // Providing data to View Details
            displayname.Text = objName;
            displayemail.Text = objEmail;
            displayphone.Text = objPhone;
        }
    }
}

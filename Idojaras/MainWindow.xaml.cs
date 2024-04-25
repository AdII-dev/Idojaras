using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Idojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
        
        
        
        
        }
        private void VarosAdd_GotFocus(object sender, RoutedEventArgs e)
        {
            if (VarosAdd.Text == "Város Neve")
            {
                VarosAdd.Text = string.Empty;
            }
        }

        private void VarosAdd_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void homersekletAdd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void paraAdd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void szelsebessegAdd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
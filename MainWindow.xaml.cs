/* Ethan Shipston
 * U5Quadratic
 * 5/28/2018
 * The program tells you the roots of a quadratic formula
 */
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

namespace U5Quadratic
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
            double.TryParse(txtA.Text, out double a);
            txtOutput.Text += "a Value: " + a.ToString() + "\n";
            double.TryParse(txtB.Text, out double b);
            txtOutput.Text += "b Value: " + b.ToString() + "\n";
            double.TryParse(txtC.Text, out double c);
            txtOutput.Text += "c Value: " + c.ToString() + "\n";
            double[] intercepts = new double[2];
            intercepts[0] = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            intercepts[1] = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            txtOutput.Text += "x Intercept(s): " + intercepts[0] + " and " + intercepts[1];
        }
    }
}

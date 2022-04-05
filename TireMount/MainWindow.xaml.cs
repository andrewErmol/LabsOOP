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
using TireMountLibrary;

namespace TireMount
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

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            Service.SetDataForTireMountWork();
        }

        private void ViewDataOfWorkWith_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Service.ViewWorksOfAutomobileModel(MyTextBox.Text));
        }

        private void MoreWorkOfAutomobile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Service.MoreWorkForAutoModel(MyTextBox.Text));
        }

        private void CostOfWorks_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

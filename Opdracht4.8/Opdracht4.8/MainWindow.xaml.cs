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

namespace Opdracht4._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double r1 = 4.7;
            double r2 = 6.8;
            double answerSerieschakeling = r1 + r2;
            double answerParallelschakeling = (r1 * r2) / (r1 + r2);
            lblSerieweerstand.Content = "Antwoord van serieschakeling is: " + answerSerieschakeling;
            lblParallelweerstand.Content = "Antwoord van parallelschakeling: " + answerParallelschakeling;
        }

    }
}

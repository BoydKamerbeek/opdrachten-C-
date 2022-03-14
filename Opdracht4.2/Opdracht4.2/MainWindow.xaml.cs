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

namespace Opdracht4._2
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
            double radius;
            radius = Convert.ToDouble(txbInput.Text);
            double volume;
            double area;
            double circumference;
            volume = (4 * Math.PI / 3) * Math.Pow(radius, 3);
            area = Math.PI * Math.Pow(radius, 2);
            circumference = 2 * Math.PI * radius;
          
            lblAnswerVolume.Content = "Volume is: " + volume;
            lblAnswerArea.Content = "Area is: " + area;
            lblAnswerCircumference.Content = "Circumference is: " + circumference;

        }
    }
}

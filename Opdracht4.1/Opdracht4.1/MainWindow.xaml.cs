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

namespace Opdracht4._1
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
            int area;
            int volume;
            int length;
            int width;
            int height;
            length = 20;
            width = 10;
            height = 10;
            area = length * width;
            volume = length * width * height;
            MessageBox.Show("Area is: " + area + " Volume is: " + volume);
            MessageBox.Show("Length is: " + length + " Width is: " + width + " Height is: " + height);
        }
    }
}

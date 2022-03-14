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

namespace Opdracht4._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnBuyDrink.Click += BtnBuyDrink_Click;
        }

        private void BtnBuyDrink_Click(object sender, RoutedEventArgs e)
        {
     
            int answer;
        


            int input = 300;
            int drink = 150;
            int change = input - drink;

             int coin100 = change / 100;
             change = change % 100;
             int coin50 = change / 50;
            change = change % 50;
            int coin20 = change / 20;
            change = change % 20;
            int coin10 = change / 10;
            change = change % 10;
            int coin5 = change / 5;
            change = change % 5;

            lbl1.Content = "Number of 1 euro coins is: " + coin100;
            lbl50.Content = "number of 50 cent coins is: " + coin50;
            lbl20.Content = "Number of 20 cent coins is: " + coin20;
            lbl10.Content = "NNumber of 10 cent coins is: " + coin10;
            lbl5.Content = "Number of 5 cent coins is: " + coin5;
            


        }
    }
}

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

namespace LancioDado
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtNumero.Text);
            if (a > 6 || a < 1)
            {
                MessageBox.Show("Il numero non è corretto", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNumero.Clear();
            }
            else
            {
                Random r = new Random();
                int b = r.Next(1, 6);
                if (a == b)
                {
                    txtResult.Text = string.Format($"Il numero uscito è {b} Hai vinto!!");
                }
                else
                    txtResult.Text = string.Format($"Il numero uscito è {b} Hai perso! Riprova");
                a = 0;
                b = 0;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtNumero.Clear();
            txtResult.Clear();
        }
    }
}

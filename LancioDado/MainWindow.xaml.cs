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

        Random random = new Random();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int da = 1;
            int a = 6;
            int NumeroCasuale = random.Next(da, a);
            int crediti = int.Parse(TxtCrediti.Text);
            int puntata = int.Parse(txtPuntata.Text);
            if (crediti <= 0)
            {
                MessageBox.Show("Inserisci numero crediti positivo");
            }
            try
            {
                int n = int.Parse(txtDado.Text);
                if (n>= 7 || n <= 0)
                {
                    MessageBox.Show("Lancia il dado! Inserisci un numero da 1 a 6");
                }
                else if(NumeroCasuale == n)
                {
                    txtResult.Text = ($"Il numero uscito è {NumeroCasuale}.Hai vinto!");
                    crediti = crediti * 2;
                    TxtCrediti.Text = ($"{ crediti}");
                }else if (NumeroCasuale != n)
                {
                    txtResult.Text = ($"Il numero uscito è {NumeroCasuale}.Hai perso");
                    crediti= crediti - puntata;
                    TxtCrediti.Text = ($"{ crediti}");
                    dado.Source = new BitmapImage(new Uri($@"Dadi/dado{NumeroCasuale}.png", UriKind.Relative));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Il numero uscito è{NumeroCasuale}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtDado.Clear();
            txtResult.Clear();
            txtPuntata.Clear();
            dado.Source = null;
        }
    }
}

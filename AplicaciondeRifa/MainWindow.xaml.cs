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
using AplicaciondeRifa.Clases;

namespace AplicaciondeRifa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rifa casa = new Rifa();
        public string[] concursantes = {"Henry", "Lesly", "Jorge", "Ángeles", "Geiser", "Zoe", "Omar",
        "Juan", "Ana", "Marlon"};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttnEmpezar_Click(object sender, RoutedEventArgs e)
        {
            int premios = casa.GeneraPremio(); 
            CantPremios.Text = Convert.ToString(casa.GeneraPremio());
           casa.rifa(concursantes, casa.GeneraPremio());

        }
    }
}

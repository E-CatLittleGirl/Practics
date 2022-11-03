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
using System.Windows.Shapes;

namespace Factory
{
    /// <summary>
    /// Логика взаимодействия для Autarization.xaml
    /// </summary>
    public partial class Autarization : Window
    {
        public Autarization()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            Hide();
        }

        private void auto_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}

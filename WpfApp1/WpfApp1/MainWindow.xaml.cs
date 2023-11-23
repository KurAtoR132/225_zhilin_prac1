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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            double a, V, S;
            if (!double.TryParse(NumberA.Text, out a))
            {
                MessageBox.Show("только число");

            }
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
            Answer.Text += $"V = {V}\nS={S}";
        }
    }
}

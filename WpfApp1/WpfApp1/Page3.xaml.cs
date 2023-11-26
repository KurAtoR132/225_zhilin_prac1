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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k, m;
            Console.Write(«K: «);
            k = Convert.ToInt16(Console.ReadLine());
            m = (k % 7) + 1;
            if (m == 1) { Console.WriteLine(«M: » +m + «-» + «Monday»); }
            else if (m == 2) { («M: » +m + «-» + «Tuesday»); }
            else if (m == 3) {(«M: » +m + «-» + «Wensday»); }
            else if (m == 4) { («M: » +m + «-» + «Thursday»); }
            else if (m == 5) { («M: » +m + «-» + «Friday»); }
            else if (m == 6) {(«M: » +m + «-» + «Saturday»); }
            else if (m == 7) { («M: » +m + «-» + «Sunday»); }
            else (MessageBox)
        }
    }
}
  
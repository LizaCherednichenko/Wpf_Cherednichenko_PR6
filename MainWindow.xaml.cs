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

namespace Wpf_Cherednichenko_PR6
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

        string l;
        string par;
        string a = "admin";
        string p = "1234";

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            l = login.Text;
            par = parol.Text;

            if (l != a)
            {
                MessageBox.Show("Неверный логин");
            }
            
            else if (par != p)
            {
                MessageBox.Show("Неверный пароль");
            }
            
            else if (l == a && par == p)
                {
                
            }
        }
    }
}

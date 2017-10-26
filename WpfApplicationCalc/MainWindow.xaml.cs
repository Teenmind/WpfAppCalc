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

namespace WpfApplicationCalc
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
            int a = Convert.ToInt32(aTxt.Text);
            int b = Convert.ToInt32(bTxt.Text);
            char op = Convert.ToChar(oPer.Text);
            try
            {
                int res = calc(a, b, op);
                resTxt.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                resTxt.Text = "∞";
            }
        }

        public int calc(int a, int b, char op)
        {
            int res = 0;
            if (op == '+')
                res = a + b;
            if (op == '-')
                res = a - b;
            if (op == '*')
                res = a * b;
            if (op == '/')
                if (b == 0)
                    throw new DivideByZeroException();
                else
                    res = a / b;
            return res;

            //∞
        }
    }
}

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
using static System.Math;


namespace _5_1_4
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
        void Button_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(Rezult_a.Text);
            int B = Convert.ToInt32(Rezult_b.Text);
            if (A > B) { A = A / B; }
            else { TextBlockAnswer.Text = $"вы ввели числа неправильно"; }
            TextBlockAnswer.Text = $"{A}";
        }
    }
}

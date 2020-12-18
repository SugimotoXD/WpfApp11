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

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                int n = int.Parse(Razmer.Text);
                mas = new int[n];
                string st = "";
                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(99) + 1;//0..9
                    st += mas[i] + " ";
                }
                Result.Text = "Сгенерированный массив:" + Environment.NewLine + st + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int max, min;
            max = min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max) max = mas[i];
                if (mas[i] < min) min = mas[i];
            }
            int sum = max + min;
            Result.Text += "Сумма мин и макс:" + sum.ToString() + Environment.NewLine;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int max, min;
            max = min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max) max = mas[i];
                if (mas[i] < min) min = mas[i];
            }
            Result.Text += "Максимальный элемент массива:" + max.ToString() + Environment.NewLine;


        }


    }
}
       
    
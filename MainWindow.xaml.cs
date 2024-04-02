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

namespace TechProgram5
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
            string TB1 = textBox1.Text;
            if (uint.TryParse(TB1, out uint x))
            {
                double rez = Math.Pow(x, 2);
                textBox2.Text = rez.ToString();
                CustomMessageBox customMessageBox = new CustomMessageBox();
                bool? result = customMessageBox.ShowDialog();

                if (result.HasValue && result.Value) 
                {
                    rez = Math.Pow(rez, 2);
                    textBox2.Text = rez.ToString();
                    
                }
                else 
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введены некорректные данные", "Тип данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

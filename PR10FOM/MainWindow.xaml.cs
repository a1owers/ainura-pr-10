using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfLibrary1.NumberCounter;

namespace PR10FOM
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
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                string[] numberStrings = input.Split(' ');

                if (!numberStrings.All(s => int.TryParse(s, out _)))
                {
                    txtResult.Text = "Неправильно введены значения.";
                    return;
                }

                var numbers = numberStrings.Select(int.Parse).Where(n => n >= -100 && n <= 100).ToList();
                if (numbers.Count == 0)
                {
                    txtResult.Text = "Не введены числа.";
                    return;
                }

                var result = numbers.Count();

                txtResult.Text = $"Четных: {result.chet}\nНечетных: {result.nechet}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"ошибка: {ex.Message}";
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Фоминов Артем";
            int job = 10;
            string task = "Дан массив в диапазоне [-100;100] найти количество Четных и \r\nНечетных.";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }
        
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    
    }
}
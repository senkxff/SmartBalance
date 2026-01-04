using SmartBalance.Views.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SmartBalance.Views.Controls.PagesControls.ExpensesPageControls
{
    /// <summary>
    /// Логика взаимодействия для PhoneExpensesControl.xaml
    /// </summary>
    public partial class PhoneExpensesControl : UserControl
    {
        public PhoneExpensesControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.DarkCyan);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Red;
        }

        private void Grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.LightSeaGreen);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.IndianRed;
        }

        // Подгрузка страницы "AddExpensesPage"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddExpensesPage addIncomePage = new AddExpensesPage();

            Navigate(addIncomePage);
        }
        private async void Navigate(Page page)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;

            if (mainWindow != null)
            {
                // плавное закрытие текущей страницы
                var fadeOut = new DoubleAnimation()
                {
                    From = 1,
                    To = 0,
                    Duration = TimeSpan.FromSeconds(0.3)
                };
                mainWindow.Frame.BeginAnimation(UIElement.OpacityProperty, fadeOut);

                await Task.Delay(300);

                // плавное открытие другой страницы
                mainWindow.Frame.Opacity = 0;
                mainWindow.Frame.Content = page;

                var fadeIn = new DoubleAnimation()
                {
                    From = 0,
                    To = 1,
                    Duration = TimeSpan.FromSeconds(0.7)
                };
                mainWindow.Frame.BeginAnimation(UIElement.OpacityProperty, fadeIn);
            }
        }
    }
}

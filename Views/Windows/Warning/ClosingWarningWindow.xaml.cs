using System.Windows;

namespace SmartBalance.Views.Windows.Warning
{
    /// <summary>
    /// Логика взаимодействия для ClosingWarningWindow.xaml
    /// </summary>
    public partial class ClosingWarningWindow : Window
    {
        public ClosingWarningWindow()
        {
            InitializeComponent();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

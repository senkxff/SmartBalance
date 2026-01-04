using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.WalletsPageControls
{
    /// <summary>
    /// Логика взаимодействия для CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        public CashControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.DarkGreen);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.DarkSlateGray;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.Green);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.Gray;
        }
    }
}

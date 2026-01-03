using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.ExpensesPageControls
{
    /// <summary>
    /// Логика взаимодействия для ShoppingExpensesControl.xaml
    /// </summary>
    public partial class ShoppingExpensesControl : UserControl
    {
        public ShoppingExpensesControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.YellowGreen);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Red;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.GreenYellow);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.IndianRed;
        }
    }
}

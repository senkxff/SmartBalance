using System.Windows.Controls;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.ExpensesPageControls
{
    /// <summary>
    /// Логика взаимодействия для RestExpensesControl.xaml
    /// </summary>
    public partial class RestExpensesControl : UserControl
    {
        public RestExpensesControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Red;
        }

        private void Grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.SandyBrown);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.IndianRed;
        }
    }
}

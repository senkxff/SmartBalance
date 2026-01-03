using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SmartBalance.Views.Controls.PagesControls.ExpensesPageControls
{
    /// <summary>
    /// Логика взаимодействия для FoodExpensesControl.xaml
    /// </summary>
    public partial class FoodExpensesControl : UserControl
    {
        public FoodExpensesControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.SlateBlue);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Red;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.IndianRed;
        }
    }
}

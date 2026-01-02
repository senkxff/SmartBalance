using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.IncomePageControls
{
    /// <summary>
    /// Логика взаимодействия для SalaryControl.xaml
    /// </summary>
    public partial class SalaryControl : UserControl
    {
        public SalaryControl()
        {
            InitializeComponent();
        }

        // Изменение при наведении
        private void Grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.DarkOrange);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Green;
        }
        private void Grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.Orange);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.ForestGreen;
        }
    }
}

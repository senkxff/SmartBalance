using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.IncomePageControls
{
    /// <summary>
    /// Логика взаимодействия для AdditionalncomeControl.xaml
    /// </summary>
    public partial class AdditionalncomeControl : UserControl
    {
        public AdditionalncomeControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Green;
            Ellipse.Fill = new SolidColorBrush(Colors.DeepPink);
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.ForestGreen;
            Ellipse.Fill = new SolidColorBrush(Colors.HotPink);
        }
    }
}

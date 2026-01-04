using System.Windows.Controls;
using System.Windows.Media;

namespace SmartBalance.Views.Controls.PagesControls.WalletsPageControls
{
    /// <summary>
    /// Логика взаимодействия для CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.DarkBlue);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.DarkSlateGray;
        }

        private void Grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.Blue);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.Gray;
        }
    }
}

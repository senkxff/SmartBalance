using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartBalance.Views.Controls.PagesControls.ExpensesPageControls
{
    /// <summary>
    /// Логика взаимодействия для TransportExpensesControl.xaml
    /// </summary>
    public partial class TransportExpensesControl : UserControl
    {
        public TransportExpensesControl()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.Orange);
            Title.Foreground = Brushes.DarkSlateGray;
            Sum.Foreground = Brushes.Red;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = new SolidColorBrush(Colors.Yellow);
            Title.Foreground = Brushes.Gray;
            Sum.Foreground = Brushes.IndianRed;
        }
    }
}

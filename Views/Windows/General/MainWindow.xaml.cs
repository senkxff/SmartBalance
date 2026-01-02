using SmartBalance.Views.Controls.BaseControls;
using SmartBalance.Views.Pages;
using SmartBalance.Views.Windows.Warning;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace SmartBalance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // объявление и создание страниц
        private readonly IncomePage incomePage = new();

        public MainWindow()
        {
            InitializeComponent();
            Navigate(incomePage);
        }

        private void CloseControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClosingWarningWindow closingWarningWindow = new ClosingWarningWindow();
            closingWarningWindow.Owner = this;
            closingWarningWindow.ShowDialog();
        }

        private void Narrow_ExpandControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Narrow_ExpandControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                Narrow_ExpandControl.ToolTip = "Расширить";
            }
            else
            {
                Narrow_ExpandControl.ToolTip = "Уменьшить";
            }
        }

        private void CollapseControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // подгрузка страниц
        private void Navigate(Page page)
        {
            Frame.Content = page;
            Frame.Opacity = 0;

            var animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(0.4)
            };

            Frame.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void IncomeControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Navigate(incomePage);
        }
    }
}
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
        // данные окна
        private double normalLeft;
        private double normalTop;

        private bool isMaximized = false;

        // объявление и создание страниц
        static internal readonly IncomePage incomePage = new();
        static internal readonly ExpensesPage expensesPage = new();
        private readonly WalletsPage walletsPage = new();
        private readonly AnalyticPage analyticPage = new();
        private readonly StoryPage storyPage = new();
        private readonly AdvicePage advicePage = new();
        private readonly SettingsPage settingsPage = new();

        public MainWindow()
        {
            InitializeComponent();
            Navigate(incomePage);
        }

        // Базовые кнопки
        private void CloseControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClosingWarningWindow closingWarningWindow = new ClosingWarningWindow();
            closingWarningWindow.Owner = this;

            closingWarningWindow.ShowDialog();
        }

        private void Narrow_ExpandControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!isMaximized)
            {
                normalLeft = this.Left;
                normalTop = this.Top;

                this.Left = SystemParameters.WorkArea.Left;
                this.Top = SystemParameters.WorkArea.Top;
                this.Width = SystemParameters.WorkArea.Width;
                this.Height = SystemParameters.WorkArea.Height;
            }
            else
            {
                this.Left = normalLeft;
                this.Top = normalTop;
                this.Width = 1000;
                this.Height = 600;
            }
            
            isMaximized = !isMaximized;
        }

        private void Narrow_ExpandControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (!isMaximized)
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

        private void IncomeControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(incomePage);
        private void ExpensesControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(expensesPage);
        private void WalletsControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(walletsPage);
        private void AnalyticControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(analyticPage);
        private void StoryControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(storyPage);
        private void AdviceControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(advicePage);
        private void SettingsControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Navigate(settingsPage);
    }
}
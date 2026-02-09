using SmartBalance.Models;
using SmartBalance.ViewModels.Base;

namespace SmartBalance.ViewModels
{
    class ExpensesViewModel : ViewModelBase
    {
        private ExpensesModel expenses = new();
        public ExpensesModel Expenses
        {
            get => expenses;
            set
            {
                expenses = value;
                OnPropertyChanged();
            }
        }
    }
}

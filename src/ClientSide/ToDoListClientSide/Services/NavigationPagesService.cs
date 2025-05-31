using System.Windows.Controls;
using ToDoListClientSide.View.Pages;
using ToDoListClientSide.ViewModel;
using ToDoListClientSide.ViewModel.Base;

namespace ToDoListClientSide.Services
{
    public class NavigationPagesService
    {
        private readonly Dictionary<Type, Type> _pageViewModels;
        private readonly Frame _frame;

        public NavigationPagesService(Frame frame)
        {
            _frame = frame;
            _pageViewModels = new();

            _pageViewModels.Add(typeof(ListOfTasksViewModel), typeof(ListOfTasksPage));
        }

        public void NavigateTo<TViewModel>(object parameter = null) where TViewModel : BaseViewModel
        {
            Type viewModelType = typeof(TViewModel);
            if (_pageViewModels.TryGetValue(viewModelType, out Type viewType))
            {
                var view = (Page)Activator.CreateInstance(viewType);
                var viewModel = (BaseViewModel)Activator.CreateInstance(viewModelType);
                viewModel.NavigationService = this;
                viewModel.Initialize(parameter);
                view.DataContext = viewModel;
                _frame.Navigate(view);
            }
        }
    }
}

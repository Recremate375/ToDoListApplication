using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoListClientSide.Services;
using ToDoListClientSide.View.Pages;
using ToDoListClientSide.ViewModel;

namespace ToDoListClientSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationPagesService _navigationService { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _navigationService = new(MainFrame);
            _navigationService.NavigateTo<ListOfTasksViewModel>();
        }
    }
}
using ModelViewViewModel.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ModelViewViewModel.ViewModels
{
    public class NavigationViewModel
    {
        public ObservableCollection<BaseViewModel> ViewModels { get; set; }

        public ICommand ManuSelected {  get; set; }

        public NavigationViewModel()
        {
            ViewModels = new ObservableCollection<BaseViewModel>
            {
                new TodoViewModel(),
                new SampleViewModel(),
            };
        }
    }
}

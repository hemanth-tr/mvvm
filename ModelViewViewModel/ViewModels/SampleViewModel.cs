using ModelViewViewModel.Views;

namespace ModelViewViewModel.ViewModels
{
    public class SampleViewModel : BaseViewModel
    {
        public SampleViewModel()
        {
            UserControl = nameof(SampleControl);
        }
    }
}

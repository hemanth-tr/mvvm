using ModelViewViewModel.Models;
using ModelViewViewModel.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ModelViewViewModel.Views
{
    /// <summary>
    /// Interaction logic for NavigationControl.xaml
    /// </summary>
    public partial class NavigationControl : UserControl
    {
        public static event NavigationEventHandler NavigationItemChanged;
        public NavigationControl()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
            {
                throw new Exception("ViewModel not found");
            }

            var selecteItem = (BaseViewModel)e.NewValue;
            UserControl selectedControl = null;
            switch(selecteItem.UserControl)
            {
                case nameof(TodoControl):
                    selectedControl = new TodoControl();
                    break;
                case nameof(SampleControl): selectedControl = new SampleControl();
                    break;
                default:
                    selectedControl = new TodoControl();
                    break;
            }
            var eventArgs = new NavigationEventArgs
            {
                UserControl = selectedControl
            };

            NavigationItemChanged?.Invoke(this, eventArgs);
        }
    }
}

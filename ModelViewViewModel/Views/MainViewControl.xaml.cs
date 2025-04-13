using ModelViewViewModel.Models;
using System.Windows.Controls;

namespace ModelViewViewModel.Views
{
    /// <summary>
    /// Interaction logic for MainViewControl.xaml
    /// </summary>
    public partial class MainViewControl : UserControl
    {
        public MainViewControl()
        {
            InitializeComponent();
            NavigationControl.NavigationItemChanged += NavigationControl_NavigationItemChanged;
        }

        private void NavigationControl_NavigationItemChanged(object? sender, NavigationEventArgs e)
        {
            this.MainView.Content = e.UserControl;
        }
        ~MainViewControl() 
        {
            NavigationControl.NavigationItemChanged -= NavigationControl_NavigationItemChanged;
        }
    }
}

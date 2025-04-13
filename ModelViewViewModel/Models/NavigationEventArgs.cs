using System.Windows.Controls;

namespace ModelViewViewModel.Models
{
    public class NavigationEventArgs : EventArgs
    {
        public UserControl UserControl { get; set; }
    }
}

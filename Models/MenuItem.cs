using System.Windows;
using System.Windows.Controls;

namespace QLCBClient.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public object Content { get; set; }
        public Thickness MarginRequirement { get; set; }
        public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement { get; set; }
        public ScrollBarVisibility VerticalScrollBarVisibilityRequirement { get; set; }
    }
}

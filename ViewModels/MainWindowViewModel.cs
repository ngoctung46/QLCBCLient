using QLCBClient.Models;
using QLCBClient.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLCBClient.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public ReactiveList<MenuItem> Menu { get; set; }
        public MainWindowViewModel()
        {
            Menu = new ReactiveList<MenuItem>
            {
                new MenuItem() {Name = "Trang Chủ", Content = new HomeView()},
                new MenuItem() {Name = "Cài Đặt", Content = new SettingView(), MarginRequirement = new Thickness(16)},
            };
        }
    }
}

using QLCB.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLCBClient.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            AddOfficers();
        }

        public void AddOfficers()
        {
            var officers = new List<Officer>();

            // dummy data
            for (int i = 1; i <= 20; i++)
            {
                officers.Add(new Officer { Name = $"Officer{i}" });
            }
            foreach (var officer in officers)
            {
                if (RootWrapPanel.FindName($"{officer.Name}") is OfficerView officerView)
                    RootWrapPanel.UnregisterName($"{officer.Name}");
                officerView = new OfficerView() { Name = $"{officer.Name}" };
                RootWrapPanel.RegisterName(officerView.Name, officerView);
                RootWrapPanel.Children.Add(officerView);
            }
        }
    }
}

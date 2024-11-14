using MasterFloor.Classes;
using MasterFloor.Model;
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

namespace MasterFloor.Frames
{
    /// <summary>
    /// Логика взаимодействия для Partners.xaml
    /// </summary>
    public partial class Partners : Page
    {
        public Partners()
        {
            InitializeComponent();
            OnStart();
        }
        private void OnStart()
        {
            List<PartnersWithDiscount> partnersWithDiscounts = new List<PartnersWithDiscount>();
            List<Model.Partners> partners = Model.MasterFloorDBEntities.GetContext().Partners.ToList();
            foreach (var partner in partners)
            {                
                partnersWithDiscounts.Add(new PartnersWithDiscount(partner));
            }
            PartnersListView.ItemsSource = partnersWithDiscounts.ToList();
        }

        private void EditPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Navigation.ActiveFrame.Navigate(new Frames.AddEditPartner((sender as Button).DataContext as PartnersWithDiscount));
        }

        private void ViewPartnerHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Navigation.ActiveFrame.Navigate(new Frames.PartnerHistory((sender as Button).DataContext as Model.Partners));
        }

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Navigation.ActiveFrame.Navigate(new Frames.AddEditPartner(null));
        }
    }
}

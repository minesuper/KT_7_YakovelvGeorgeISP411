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
    /// Логика взаимодействия для PartnerHistory.xaml
    /// </summary>
    public partial class PartnerHistory : Page
    {
        public PartnerHistory(Model.Partners SelectedPartner)
        {
            InitializeComponent();
            OnStart(SelectedPartner);
        }
        private void OnStart(Model.Partners SelectedPartner)
        {
            HistoryListView.ItemsSource = Model.MasterFloorDBEntities.GetContext().PartnerProduct
                .Where(d => d.PartnerId == SelectedPartner.Id).ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.Navigation.ActiveFrame.CanGoBack)
            {
                Classes.Navigation.ActiveFrame.GoBack();
            }
        }
    }
}

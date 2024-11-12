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
    /// Логика взаимодействия для AddEditPartner.xaml
    /// </summary>
    public partial class AddEditPartner : Page
    {
        bool IsAdding { get; set; }
        Model.MasterFloorDBEntities Context = Model.MasterFloorDBEntities.GetContext();
        Model.Partners CurrentPartner { get; set; }
        public AddEditPartner(Model.Partners SelectedParner)
        {
            InitializeComponent();
            OnStart(SelectedParner);
        }
        private void OnStart(Model.Partners SelectedPartner)
        {
            if (SelectedPartner == null)
            {
                IsAdding = true;
                CurrentPartner = new Model.Partners();
            }
            else
            {
                IsAdding = false;
                DataContext = SelectedPartner;
                CurrentPartner = SelectedPartner;
                NameTextBox.Text = SelectedPartner.PartnerName.Name;
                TypeComboBox.SelectedIndex = SelectedPartner.PartnerTypeId - 1;
                RatingTextBox.Text = SelectedPartner.Rating.ToString();
                AdressTextBox.Text = $"{SelectedPartner.AdressIndex}, {SelectedPartner.Region.Name}, " +
                    $"{SelectedPartner.City.Name}, {SelectedPartner.Street.Name}, {SelectedPartner.AdressHouseNum}";
                FIOTextBox.Text = $"{SelectedPartner.DirectorSurname} {SelectedPartner.DirectorName} {SelectedPartner.DirectorPatronym}";
                PhoneTextBox.Text = SelectedPartner.Phone;
                EmailTextBox.Text = SelectedPartner.Email;
            }
            TypeComboBox.ItemsSource = Context.PartnerType.ToList();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.Navigation.ActiveFrame.CanGoBack)
            {
                Classes.Navigation.ActiveFrame.GoBack();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                string Name = NameTextBox.Text;
                int TypeId = TypeComboBox.SelectedIndex + 1;
                string RatingText = RatingTextBox.Text;
                string AdressFull = AdressTextBox.Text.Trim();
                string FIOFull = FIOTextBox.Text.Trim();
                string Phone = PhoneTextBox.Text;
                string Email = EmailTextBox.Text;
                string AdressIndex = "", AdressRegion = "", AdressCity = "", AdressStreet = "", AdressHouseNum = "";
                if (string.IsNullOrEmpty(Name))
                {
                    errors.AppendLine("Заполните имя поставщика");
                }
                if (TypeId < 1)
                {
                    errors.AppendLine("Выберите тип поставщика");
                }
                if (string.IsNullOrEmpty(RatingText))
                {
                    errors.AppendLine("Заполните рейтинг поставщика");
                }
                else if (!Int32.TryParse(RatingText, out var res))
                {
                    errors.AppendLine("Рейтинг - целое число");
                }
                else if (Int32.Parse(RatingText) < 0)
                {
                    errors.AppendLine("Рейтинг - неотрицательное число");
                }
                if (string.IsNullOrEmpty(AdressFull))
                {
                    errors.AppendLine("Заполните адрес поставщика");
                }
                else if (AdressFull.Split(',').Length != 5)
                {
                    errors.AppendLine("Адрес заполнен не по шаблону (Индекс, регион, город, улица, дом)");
                }
                else
                {
                    List<string> AdressSplitted = AdressFull.Split(',').ToList();
                    AdressIndex = AdressSplitted[0].Trim();
                    AdressRegion = AdressSplitted[1].Trim();
                    AdressCity = AdressSplitted[2].Trim();
                    AdressStreet = AdressSplitted[3].Trim();
                    AdressHouseNum = AdressSplitted[4].Trim();
                    if (!Int32.TryParse(AdressIndex, out var resIndex))
                    {
                        errors.AppendLine("Индекс - целое число");
                    }
                    else if (Int32.Parse(AdressIndex) <= 0)
                    {
                        errors.AppendLine("Индекс - положительное число");
                    }
                    if (!Int32.TryParse(AdressHouseNum, out var resHouseNum))
                    {
                        errors.AppendLine("Номер дома - целое число");
                    }
                    else if (Int32.Parse(AdressHouseNum) <= 0)
                    {
                        errors.AppendLine("Номер дома - положительное число");
                    }
                    if (AdressIndex.Length > 50)
                    {
                        errors.AppendLine("Индекс слишком большой");
                    }
                    if (AdressRegion.Length > 50)
                    {
                        errors.AppendLine("Регион слишком большой");
                    }
                    if (AdressCity.Length > 50)
                    {
                        errors.AppendLine("Город слишком большой");
                    }
                    if (AdressStreet.Length > 50)
                    {
                        errors.AppendLine("Улица слишком большой");
                    }
                    if (AdressHouseNum.Length > 50)
                    {
                        errors.AppendLine("Номер дома слишком большой");
                    }
                }
                if (string.IsNullOrEmpty(FIOFull))
                {
                    errors.AppendLine("Заполните ФИО поставщика");
                }
                else if (FIOFull.Split(' ').Length != 3)
                {
                    errors.AppendLine("ФИО заполнено неправильно");
                }
                if (string.IsNullOrEmpty(Phone))
                {
                    errors.AppendLine("Заполните номер поставщика");
                }
                if (string.IsNullOrEmpty(Email))
                {
                    errors.AppendLine("Заполните email поставщика");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!Context.PartnerName.Any(d => d.Name == Name))
                {
                    Context.PartnerName.Add(new Model.PartnerName() { Name = Name });
                    Context.SaveChanges();
                }
                CurrentPartner.PartnerNameId = Context.PartnerName.Where(d => d.Name == Name).FirstOrDefault().Id;
                CurrentPartner.PartnerTypeId = TypeId;
                CurrentPartner.Rating = Int32.Parse(RatingText);
                CurrentPartner.AdressIndex = AdressIndex;
                if (!Context.Region.Any(d => d.Name == AdressRegion))
                {
                    Context.Region.Add(new Model.Region() { Name = AdressRegion });
                    Context.SaveChanges();
                }
                CurrentPartner.AdressRegionId = Context.Region.Where(d => d.Name == AdressRegion).FirstOrDefault().Id;
                if (!Context.City.Any(d => d.Name == AdressCity))
                {
                    Context.City.Add(new Model.City() { Name = AdressCity });
                    Context.SaveChanges();
                }
                CurrentPartner.AdressCityId = Context.City.Where(d => d.Name == AdressCity).FirstOrDefault().Id;
                if (!Context.Street.Any(d => d.Name == AdressStreet))
                {
                    Context.Street.Add(new Model.Street() { Name = AdressStreet });
                    Context.SaveChanges();
                }
                CurrentPartner.AdressStreetId = Context.Street.Where(d => d.Name == AdressStreet).FirstOrDefault().Id;
                CurrentPartner.AdressHouseNum = Int32.Parse(AdressHouseNum);
                List<string> FIOSplitted = FIOFull.Split(' ').ToList();
                CurrentPartner.DirectorSurname = FIOSplitted[0].Trim();
                CurrentPartner.DirectorName = FIOSplitted[1].Trim();
                CurrentPartner.DirectorPatronym = FIOSplitted[2].Trim();
                CurrentPartner.Phone = Phone;
                CurrentPartner.Email = Email;
                if (IsAdding)
                {
                    Context.Partners.Add(CurrentPartner);
                }
                Context.SaveChanges();
                MessageBox.Show("Успешно сохранено!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                Classes.Navigation.ActiveFrame.RemoveBackEntry();
                Classes.Navigation.ActiveFrame.Navigate(new Frames.Partners());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

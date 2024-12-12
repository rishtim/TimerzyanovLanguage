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

namespace TimerzyanovLanguage
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>

    public partial class ClientPage : Page
    {
        List<Client> CurrentPageList = new List<Client>();
        List<Client> TableList;
        int CountRecords;
        int CountPage;
        int CurrentPage = 0;
        int CountInPage;

        public ClientPage()
        {
            InitializeComponent();
            var currentClients = TimerzyanovLanguageEntities.GetContext().Client.ToList();
            ClientListView.ItemsSource = currentClients;
            PageComboBox.SelectedIndex = 0;
            FiltrBox.SelectedIndex = 0;
            SortBox.SelectedIndex = 0;
            UpdateClients();
        }

        private void UpdateClients()
        {
            var currentClients = TimerzyanovLanguageEntities.GetContext().Client.ToList();
            if (SortBox.SelectedIndex == 1)
            {
                currentClients = currentClients.OrderBy(p => p.FirstName).ToList();
            }
            else if (SortBox.SelectedIndex == 2)
            {
                currentClients = currentClients.OrderByDescending(p => DateTime.Parse((p.LastVisitDate.ToString() != "Нет") ? p.LastVisitDate.ToString() : "01.01.1991 09:00")).ToList();
            }
            else if (SortBox.SelectedIndex == 3)
            {
                currentClients = currentClients.OrderByDescending(p => p.VisitCount).ToList();
            }

            if (FiltrBox.SelectedIndex == 1)
            {
                currentClients = currentClients.Where(p => p.GenderCode == "ж").ToList();
            }
            else if (FiltrBox.SelectedIndex == 2)
            {
                currentClients = currentClients.Where(p => p.GenderCode == "м").ToList();
            }

            currentClients = currentClients.Where(p => p.LastName.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.FirstName.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Patronymic.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Email.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Phone.Replace("+", "").Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").ToLower().Contains(TBoxSearch.Text.Replace("+", "").Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").ToLower())).ToList();

            CountInPage = 10;
            ClientListView.ItemsSource = currentClients;
            TableList = currentClients;
            if (PageComboBox.SelectedIndex == 0)
                CountInPage = 10;
            if (PageComboBox.SelectedIndex == 1)
                CountInPage = 50;
            if (PageComboBox.SelectedIndex == 2)
                CountInPage = 200;
            if (PageComboBox.SelectedIndex == 3)
                CountInPage = TableList.Count;
            ChangePage(0, 0);
        }

        private void PageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateClients();
        }

        private void PageListBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ChangePage(0, Convert.ToInt32(PageListBox.SelectedItem.ToString()) - 1);
        }

        private void LeftDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(1, null);
        }

        private void RightDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(2, null);
        }

        private void ChangePage(int direction, int? selectedPage)
        {
            CurrentPageList.Clear();
            CountRecords = TableList.Count;

            if (CountRecords % CountInPage > 0)
            {
                CountPage = CountRecords / CountInPage + 1;
            }
            else
            {
                CountPage = CountRecords / CountInPage;
            }

            Boolean Ifupdate = true;

            int min;

            if (selectedPage.HasValue)
            {
                if (selectedPage >= 0 && selectedPage <= CountPage)
                {
                    CurrentPage = (int)selectedPage;
                    min = CurrentPage * CountInPage + CountInPage < CountRecords ? CurrentPage * CountInPage + CountInPage : CountRecords;
                    for (int i = CurrentPage * CountInPage; i < min; i++)
                    {
                        CurrentPageList.Add(TableList[i]);
                    }
                }
            }
            else
            {
                switch (direction)
                {
                    case 1:
                        if (CurrentPage > 0)
                        {
                            CurrentPage--;
                            min = CurrentPage * CountInPage + CountInPage < CountRecords ? CurrentPage * CountInPage + CountInPage : CountRecords;
                            for (int i = CurrentPage * CountInPage; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;

                    case 2:
                        if (CurrentPage < CountPage - 1)
                        {
                            CurrentPage++;
                            min = CurrentPage * CountInPage + CountInPage < CountRecords ? CurrentPage * CountInPage + CountInPage : CountRecords;
                            for (int i = CurrentPage * CountInPage; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;
                }
            }
            if (Ifupdate)
            {
                PageListBox.Items.Clear();

                for (int i = 1; i <= CountPage; i++)
                {
                    PageListBox.Items.Add(i);
                }
                PageListBox.SelectedIndex = CurrentPage;

                min = CurrentPage * CountInPage + CountInPage < CountRecords ? CurrentPage * CountInPage + CountInPage : CountRecords;
                CurrentCount.Text = min.ToString();
                AllCount.Text = " из " + CountRecords.ToString();

                ClientListView.ItemsSource = CurrentPageList;
                ClientListView.Items.Refresh();

            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var currentClient = (sender as Button).DataContext as Client;

            if (currentClient.VisitCount == 0)
            {
                if (MessageBox.Show("Вы точно хотите выполнить удаление?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    TimerzyanovLanguageEntities.GetContext().Client.Remove(currentClient);
                    TimerzyanovLanguageEntities.GetContext().SaveChanges();
                    ClientListView.ItemsSource = TimerzyanovLanguageEntities.GetContext().Client.ToList();
                    UpdateClients();
                }
            }
            else
            {
                MessageBox.Show("Невозможно выполнить удаление, так как у клиента есть посещения!");
            }
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateClients();
        }

        private void FiltrBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateClients();
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateClients();
        }

        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditWindow((sender as Button).DataContext as Client).ShowDialog();
            UpdateClients();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            new AddEditWindow(null).ShowDialog();
            UpdateClients();
        }
    }
}

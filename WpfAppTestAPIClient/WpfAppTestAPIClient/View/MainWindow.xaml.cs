using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using WpfAppTestAPIClient.Model;
using WpfAppTestAPIClient.APIClient;
using WpfAppTestAPIClient.View;

namespace WpfAppTestAPIClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TascasApiClient api = new TascasApiClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnListBox_Click(object sender, RoutedEventArgs e)
        {
            WindowListBox form = new WindowListBox();
            form.ShowDialog();
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            WindowDataGrid form = new WindowDataGrid();
            form.ShowDialog();
        }





        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Tasca user = await api.GetUserAsync("Eloi");
            List<Tasca> users = await api.GetUsersAsync();
            DateTime datainici = new DateTime(2000, 12, 01);
            DateTime datafinal = new DateTime(2000, 12, 24);
            user = new Tasca() { Nom = "TascaWPF" , Autor = "Eloi", Background = "Orange", DataFinal =datafinal, DataInici = datainici ,
                Estat = "Doing", Descripcio = "fer tasca numero 4 de M07"};
            await api.AddAsync(user);
            await api.UpdateAsync(user);
            await api.DeleteAsync("Eloi");
        }
   


    }
}

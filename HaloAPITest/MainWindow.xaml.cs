using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HaloEzAPI;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HaloAPITest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        string key = "bfbfbce13da44f9db06d881c5ebb158f";
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HaloAPIService api = new HaloAPIService(key);

            var enemies = await api.GetEnemies();

            ListaInimigos.ItemsSource = enemies;

            //foreach (var match in matches.Results)
            //{
            //    textresult.Text += match.MatchDuration;
            //    textresult.Text += Environment.NewLine;
            //}
            //foreach (var item in matches)
            //{
            //    textresult.Text += item.ToString();
            //}
        }

        private void inimigohalo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DetalheInimigo detalhe = new DetalheInimigo();
            detalhe.Show();
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

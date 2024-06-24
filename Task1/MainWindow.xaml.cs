using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>
            {
                new Game{IdGame=1, Category="RPG", Name="The Elder Scrolls V: Skyrim", Price=500, Site = "https://bethesda.net/en/dashboard"},
                new Game{IdGame=2, Category="Simulator", Name="Euro Truck Simulator 2", Price=249, Site ="https://eurotrucksimulator2.com/"},
                new Game{IdGame=3, Category="Strategy", Name="Hearts of Iron IV", Price=4000, Site ="https://www.paradoxinteractive.com/games/hearts-of-iron-iv/about"},
                new Game{IdGame=4, Category="FPS", Name="Counter Strike 2", Price=0, Site="https://store.steampowered.com/app/730/CounterStrike_2/"},
                new Game{IdGame=5, Category="MOBA", Name="Dota 2", Price=0, Site="https://store.steampowered.com/app/570/Dota_2/"}
            };

            GamesListView.ItemsSource = games;
        }
    }
}
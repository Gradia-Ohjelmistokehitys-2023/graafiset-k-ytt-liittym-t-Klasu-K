using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Common;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page, IMainMenu
    {
        private MapSizes _mapSize;

        public event Action<MapSizes> GameStarted;

        Button[] mapSizeButtons;

        public MainMenu()
        {
            InitializeComponent();
            mapSizeButtons = new Button[3] { btnMapSizeSmall, btnMapSizeMedium, btnMapSizeLarge };
            SetMapSize(MapSizes.Small);
        }

        void HighlightButton(Button buttonToHighlight)
        {
            foreach (Button btn in mapSizeButtons)
            {
                btn.Background = Brushes.LightGray;
            }
            buttonToHighlight.Background = Brushes.DarkBlue;
        }

        void SetMapSize(MapSizes mapSize)
        {
            _mapSize = mapSize;
        }

        private void btnSmallClicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            HighlightButton(btn);
            SetMapSize(MapSizes.Small);
        }
        private void btnMediumClicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            HighlightButton(btn);
            SetMapSize(MapSizes.Medium);
        }
        private void btnLargeClicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            HighlightButton(btn);
            SetMapSize(MapSizes.Large);
        }

        private void btnStartGameClicked(object sender, RoutedEventArgs e)
        {
            GameStarted(_mapSize);
        }
    }
}

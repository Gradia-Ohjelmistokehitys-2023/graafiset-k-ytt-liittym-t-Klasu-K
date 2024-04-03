using Common.Data;
using Common.Interfaces;
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
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MiinaharavaWPFUI.xaml
    /// </summary>
    public partial class MiinaharavaWPFUI : Window
    {
        public event Action<MapSizes> GameStarted;
        MainMenu _mainMenuPage;
        GameboardPage _gameboardPage;
        
        public MiinaharavaWPFUI(IMainMenu mainMenu, IGameboard gameboard)
        {
            InitializeComponent();
            _mainMenuPage = mainMenu as MainMenu;
            _gameboardPage = gameboard as GameboardPage;
            _mainMenuPage.OnOpenGameboard += OpenGameboard;
            _mainFrame.Navigate(_mainMenuPage);
        }

        public void OpenGameboard()
        {
            _mainFrame.Navigate(_gameboardPage);
        }

    }
}

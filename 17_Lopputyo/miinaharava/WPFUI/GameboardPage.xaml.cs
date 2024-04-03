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
using Common.Interfaces;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for GameboardPage.xaml
    /// </summary>
    public partial class GameboardPage : Page, IGameboard
    {
        public GameboardPage()
        {
            InitializeComponent();
        }

        public int Width { get; set; }

        public void SetSize(int width, int height)
        {
            WindowWidth = width;
            WindowHeight = height;
        }


    }
}

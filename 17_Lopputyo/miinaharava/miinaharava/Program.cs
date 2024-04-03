using miinaharava.Presenter;
using System.Windows.Forms.Integration;
using WPFUI;
using Common.Interfaces;
using miinaharava.Model;
using WPFUI;

namespace miinaharava
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MiinaharavaView view = new MiinaharavaView();
            IMainMenu mainMenu = new MainMenu();
            IGameboard gameboard = new GameboardPage();
            //IMainMenu mainMenu = view;
            //IGameboard gameboard = view;

            MiinaharavaPresenter presenter = new MiinaharavaPresenter();
            IModel model = new MiinaharavaModel();
            view.Presenter = presenter;
            presenter.MainMenu = mainMenu;
            presenter.Gameboard = gameboard;
            presenter.View = view;
            presenter.Model = model;
            model.Presenter = presenter;

            presenter.Initialize();
            var aa = new MiinaharavaWPFUI(mainMenu, gameboard);
            aa.ShowDialog();
            //Application.Run(view);
        }
    }
}
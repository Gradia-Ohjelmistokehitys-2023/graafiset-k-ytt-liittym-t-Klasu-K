using miinaharava.Model;
using miinaharava.Presenter;
using System.Windows.Forms.Integration;
using Common;
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
            //IMainMenu mainMenu = new MainMenu();
            IMainMenu mainMenu = view;

            MiinaharavaPresenter presenter = new MiinaharavaPresenter();
            MiinaharavaModel model = new MiinaharavaModel();
            view.Presenter = presenter;
            presenter.MainMenu = mainMenu;
            presenter.View = view;
            presenter.Model = model;
            model.Presenter = presenter;

            presenter.Initialize();
            //var aa = new MiinaharavaWPFUI(mainMenu);
            //aa.ShowDialog();
            Application.Run(view);
        }
    }
}
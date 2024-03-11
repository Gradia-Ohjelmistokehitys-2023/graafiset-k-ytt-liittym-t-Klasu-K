using miinaharava.Model;
using miinaharava.Presenter;

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
            MiinaharavaPresenter presenter = new MiinaharavaPresenter();
            MiinaharavaModel model = new MiinaharavaModel();
            view.Presenter = presenter;
            presenter.View = view;
            presenter.Model = model;
            model.Presenter = presenter;
            Application.Run(view);
        }
    }
}
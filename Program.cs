using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipManager.View;
using TipManager.Presenter;
using TipManager.UserControls;
using TipManager.Model;
using TipManager.Services;

namespace TipManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);

            TipManagerModel tipManager = new TipManagerModel();
            TipManagerServices services = new TipManagerServices(tipManager);

            Home homeView = new Home();
            HomePresenter homePresenter = new HomePresenter(homeView, tipManager, services);

            form.Controls.Add(homeView);
            homeView.BringToFront();
        }
        static Form1 form;
    }
}

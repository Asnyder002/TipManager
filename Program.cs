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

            TipManagerModel tipManager = new TipManagerModel();
            TipManagerServices services = new TipManagerServices(tipManager);

            Home homeView = new Home();
            AddTip addTipView = new AddTip();

            TipManagerPresenter tipManagerPresenter = new TipManagerPresenter(form, homeView, addTipView);
            HomePresenter homePresenter = new HomePresenter(homeView, tipManager, services);
            AddTipPresenter addTipPresenter = new AddTipPresenter(addTipView, tipManager, services);

            form.Controls.Add(homeView);
            form.Controls.Add(addTipView);

            Application.Run(form);
        }
        static Form1 form;
    }
}

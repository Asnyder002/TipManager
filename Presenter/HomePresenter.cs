using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;
using TipManager.Services;
using TipManager.View;

namespace TipManager.Presenter
{
    class HomePresenter
    {
        //TipManagerModel tipManager = new TipManagerModel();
        TipManagerModel tipManager;

        TipManagerServices services;

        private IHome homeView;

        public HomePresenter(IHome view, TipManagerModel tipManager, TipManagerServices services)
        {
            homeView = view;
            this.tipManager = tipManager;
            this.services = services;
            //services = new TipManagerServices(tipManager);
            homeView.homeLoaded += new EventHandler(OnHomeLoaded);
        }

        public void OnHomeLoaded(object sender, EventArgs e)
        {
            DisplayTotal();
            DisplayTotalMade();
            DisplayTotalSpent();
            DisplayTotalHoursWorked();
        }

        public void DisplayTotal()
        {
            services.passTotalToModel();
            homeView.TxtTotal = "$" + tipManager.Total.ToString();

        }

        public void DisplayTotalMade()
        {
            services.passTotalMadeToModel();
            homeView.TxtTotalMade = "$" + tipManager.TotalMade.ToString();
        }

        public void DisplayTotalSpent()
        {
            services.passTotalSpentToModel();
            homeView.TxtTotalSpent = "$" + tipManager.TotalSpent.ToString();
        }

        public void DisplayTotalHoursWorked()
        {
            services.passTotalHoursWorkedToModel();
            homeView.TxtTotalHours = tipManager.TotalHours.ToString();
        }

    }
}

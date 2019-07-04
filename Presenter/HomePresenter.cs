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
        TipManagerModel tipManager = new TipManagerModel();

        TipManagerServices services;

        private IHome homeView;

        public HomePresenter(IHome view)
        {
            homeView = view;
            services = new TipManagerServices(tipManager);
            homeView.homeLoaded += new EventHandler(OnHomeLoaded);
        }

        public void OnHomeLoaded(object sender, EventArgs e)
        {
            DisplayTotal();
        }

        public void DisplayTotal()
        {
            services.passSumTotalToModel();
            homeView.TxtTotal = "$" + tipManager.Total.ToString();

        }

        public void DisplayTotalMade()
        {
            homeView.TxtTotalMade = tipManager.TotalMade.ToString();
        }

        public void DisplayTotalSpent()
        {
            homeView.TxtTotalSpent = tipManager.TotalSpent.ToString();
        }

        public void DisplayTotalHours()
        {
            homeView.TxtTotalHours = tipManager.TotalHours.ToString();
        }

    }
}

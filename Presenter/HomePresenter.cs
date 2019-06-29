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
        // Creates object from model
        TipManagerModel tipManager = new TipManagerModel();

        TipManagerServices services;

        // Creates instance from interface
        private IHome homwView;

        // Constructor
        public HomePresenter(IHome view)
        {
            homwView = view;
            services = new TipManagerServices(tipManager);
        }

        public void DisplayTotal()
        {
            services.passSumTotalToModel();
            homwView.TxtTotal = "$" + tipManager.Total.ToString();

        }

        public void DisplayTotalMade()
        {
            homwView.TxtTotalMade = tipManager.TotalMade.ToString();
        }

        public void DisplayTotalSpent()
        {
            homwView.TxtTotalSpent = tipManager.TotalSpent.ToString();
        }

        public void DisplayTotalHours()
        {
            homwView.TxtTotalHours = tipManager.TotalHours.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;
using TipManager.Services;
using TipManager.View;
using TipManager.UserControls;
using System.Windows.Forms;

namespace TipManager.Presenter
{
    class TipManagerPresenter
    {
        // Creates object from model
        TipManagerModel tipManager = new TipManagerModel();

        TipManagerServices services;

        // Creates instance from interface
        private ITipManager tipManagerView;

        // Constructor
        public TipManagerPresenter(ITipManager view)
        {
            tipManagerView = view;
            services = new TipManagerServices(tipManager);
        }

        public void DisplayTotal()
        {
            services.passSumTotalToModel();
            tipManagerView.TxtTotal = "$" + tipManager.Total.ToString();
            
        }

        public void DisplayTotalMade()
        {
            tipManagerView.TxtTotalMade = tipManager.TotalMade.ToString();
        }

        public void DisplayTotalSpent()
        {
            tipManagerView.TxtTotalSpent = tipManager.TotalSpent.ToString();
        }

        public void DisplayTotalHours()
        {
            tipManagerView.TxtTotalHours = tipManager.TotalHours.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;
using TipManager.View;

namespace TipManager.Presenter
{
    class TipManagerPresenter
    {
        // Creates object from model
        TipManagerModel tipManager = new TipManagerModel();

        // Creates instance from interface
        private ITipManager tipManagerView;

        // Constructor
        public TipManagerPresenter(ITipManager view)
        {
            tipManagerView = view;
        }

        public void DisplayTotal()
        {
            tipManagerView.TxtTotal = tipManager.Total.ToString();
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

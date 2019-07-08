using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;

namespace TipManager.Services
{
    class TipManagerServices
    {
        Repository repo = new Repository();
        private TipManagerModel tipManager;

        public TipManagerServices(TipManagerModel tipManager )
        {
            this.tipManager = tipManager;
        }

        public void passTotalToModel()
        {
            tipManager.Total = repo.GetTotal();
        }

        public void passTotalMadeToModel()
        {
            tipManager.TotalMade = repo.GetTotalMade();
        }

        public void passTotalSpentToModel()
        {
            tipManager.TotalSpent = repo.GetTotalSpent();
        }

        public void passTotalHoursWorkedToModel()
        {
            tipManager.TotalHours = repo.GetTotalHoursWorked();
        }
    }
}

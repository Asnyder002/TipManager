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

        public void PassTotalToModel()
        {
            tipManager.Total = repo.GetTotal();
        }

        public void PassTotalMadeToModel()
        {
            tipManager.TotalMade = repo.GetTotalMade();
        }

        public void PassTotalSpentToModel()
        {
            tipManager.TotalSpent = repo.GetTotalSpent();
        }

        public void PassTotalHoursWorkedToModel()
        {
            tipManager.TotalHours = repo.GetTotalHoursWorked();
        }

        public void PassDepositToRepo(Deposit deposit)
        {
            repo.AddNewDeposit(deposit);
        }

        public List<Deposit> DataSourceForAddTip()
        {
            return repo.GetDataSourceForAddTip();
        }
    }
}

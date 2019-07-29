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

        // Refactor?
        public void PassDepositToRepoToAdd(Deposit deposit)
        {
            repo.AddNewDeposit(deposit);
        }

        public void PassWithdrawToRepoToAdd(Withdraw withdraw)
        {
            repo.AddNewWithdraw(withdraw);
        }

        // Refactor?
        public void PassDepositToRepoToDelete(Deposit deposit)
        {
            repo.DeleteDeposit(deposit);
        }

        public void PassWithdrawToRepoToDelete(Withdraw withdraw)
        {
            repo.DeleteWithdraw(withdraw);
        }

        public List<Deposit> DataSourceForAddTip()
        {
            return repo.GetDataSourceForAddTip();
        }

        public List<Withdraw> DataSourceForWithdraw()
        {
            return repo.GetDataSourceForWithdraw();
        }

        public Deposit UpdateSelectedDeposit(Deposit deposit)
        {
            return repo.GetSelectedDeposit(deposit);
        }

        public Withdraw UpdateSelectedWithdraw(Withdraw withdraw)
        {
            return repo.GetSelectedWithdraw(withdraw);
        }
    }
}

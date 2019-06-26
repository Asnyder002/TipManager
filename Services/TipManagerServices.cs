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

        public void passSumTotalToModel()
        {
            tipManager.Total = repo.GetSumOfDeposits();
        }
    }
}

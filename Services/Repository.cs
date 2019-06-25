using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipManager.Services
{
    class Repository
    {
        public double GetSumOfDeposits()
        {
            using(var context = new TipManagerDBEntities())
            {
                double sum = (double)context.Deposits.Sum(d => d.DepositAmount);
                return sum;
            }
        }
    }
}

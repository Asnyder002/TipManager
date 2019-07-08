using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipManager.Services
{
    class Repository
    {
        public double GetTotal()
        {
            using(var context = new TipManagerDBEntities())
            {
                return GetTotalMade() - GetTotalSpent();
            }
        }

        public double GetTotalMade()
        {
            using (var context = new TipManagerDBEntities())
            {
                double sum = (double)context.Deposits.Sum(d => d.DepositAmount);
                return sum;
            }
        }

        public double GetTotalSpent()
        {
            using (var context = new TipManagerDBEntities())
            {
                double sum = (double)context.Withdraws.Sum(d => d.WithdrawAmount);
                return sum;
            }
        }

        public double GetTotalHoursWorked()
        {
            using (var context = new TipManagerDBEntities())
            {
                double sum = context.Deposits.Sum(d => d.HoursWorked);
                return sum;
            }
        }


    }
}

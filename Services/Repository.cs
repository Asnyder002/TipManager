using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TipManager.Services
{
    class Repository
    {
        public double GetTotal()
        {
            using(var context = new TipManagerDBEntities())
            {
                try
                {
                    return GetTotalMade() - GetTotalSpent();
                }
                catch
                {
                    return 0;
                }
                
            }
        }

        public double GetTotalMade()
        {
            using (var context = new TipManagerDBEntities())
            {
                try
                {
                    double sum = (double)context.Deposits.Sum(d => d.DepositAmount);
                    return sum;
                }
                catch
                {
                    return 0;
                }
                
            }
        }

        public double GetTotalSpent()
        {
            using (var context = new TipManagerDBEntities())
            {
                try
                {
                    double sum = (double)context.Withdraws.Sum(d => d.WithdrawAmount);
                    return sum;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public double GetTotalHoursWorked()
        {
            using (var context = new TipManagerDBEntities())
            {
                try
                {
                    double sum = context.Deposits.Sum(d => d.HoursWorked);
                    return sum;
                }
                catch
                {
                    return 0;
                }
            }
        }

        // This will need to be refactored
        public void AddNewDeposit(Deposit deposit)
        {
            using (var context = new TipManagerDBEntities())
            {
                if (deposit.DepositID == 0)
                {
                    context.Deposits.Add(deposit);
                }
                else
                {
                    context.Entry(deposit).State = EntityState.Modified;
                }
                
                context.SaveChanges();
            }
        }

        // This will need to be refactored
        public void AddNewWithdraw(Withdraw withdraw)
        {
            using (var context = new TipManagerDBEntities())
            {
                if (withdraw.WithdrawID == 0)
                {
                    context.Withdraws.Add(withdraw);
                }
                else
                {
                    context.Entry(withdraw).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public void DeleteDeposit(Deposit deposit)
        {
            using (var context = new TipManagerDBEntities())
            {
                try
                {
                    var entry = context.Entry(deposit);
                    if (entry.State == EntityState.Detached)
                    {
                        context.Deposits.Attach(deposit);
                    }
                    context.Deposits.Remove(deposit);
                    context.SaveChanges();
                }
                catch
                {

                }
            }
        }

        public void DeleteWithdraw(Withdraw withdraw)
        {
            using (var context = new TipManagerDBEntities())
            {
                try
                {
                    var entry = context.Entry(withdraw);
                    if (entry.State == EntityState.Detached)
                    {
                        context.Withdraws.Attach(withdraw);
                    }
                    context.Withdraws.Remove(withdraw);
                    context.SaveChanges();
                }
                catch
                {

                }
            }
        }


        public List<Deposit> GetDataSourceForAddTip()
        {
            using (var context = new TipManagerDBEntities())
            {
                return context.Deposits.ToList<Deposit>();
            }
        }

        public List<Withdraw> GetDataSourceForWithdraw()
        {
            using (var context = new TipManagerDBEntities())
            {
                return context.Withdraws.ToList<Withdraw>();
            }
        }

        public Deposit GetSelectedDeposit(Deposit deposit)
        {
            using (var context = new TipManagerDBEntities())
            {
                return deposit = context.Deposits.Where(x => x.DepositID ==  deposit.DepositID).FirstOrDefault();
            }
        }

        public Withdraw GetSelectedWithdraw(Withdraw withdraw)
        {
            using (var context = new TipManagerDBEntities())
            {
                return withdraw = context.Withdraws.Where(x => x.WithdrawID == withdraw.WithdrawID).FirstOrDefault();
            }
        }

    }
}

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
    class TransactionPresenter
    {
        // Private or nah
        private TipManagerModel tipManager;

        // Private or nah
        private TipManagerServices services;

        private ITransaction withdrawView;

        private Withdraw withdraw = new Withdraw();

        public TransactionPresenter(ITransaction withdrawView, TipManagerModel tipManager, TipManagerServices services)
        {
            this.withdrawView = withdrawView;
            this.tipManager = tipManager;
            this.services = services;

            withdrawView.withdrawClearButtonClicked += new EventHandler(OnWithdrawClearButtonClicked);
            withdrawView.withdrawLoaded += new EventHandler(OnWithdrawLoaded);
            withdrawView.withdrawSaveButtonClicked += new EventHandler(OnWithdrawSaveButtonClicked);
            withdrawView.withdrawDoubleClicked += new EventHandler(OnWithdrawDoubleClicked);
            withdrawView.withdrawDeleteButtonClicked += new EventHandler(OnWithdrawDeleteButtonClicked);

        }

        public void OnWithdrawClearButtonClicked(object sender, EventArgs e)
        {
            Clear();
        }

        public void OnWithdrawLoaded(object sender, EventArgs e)
        {
            Clear();
            LinkDataGridViewForWithdraw();
        }

        public void OnWithdrawSaveButtonClicked(object sneder, EventArgs e)
        {
            withdraw.WithdrawAmount = Decimal.Parse(withdrawView.TxtWithdrawAmount.Trim());
            withdraw.WithdrawDate = DateTime.Parse(withdrawView.TxtWithdrawDate.Trim());
            withdraw.WithdrawName = withdrawView.TxtCategory.Trim();
            services.PassWithdrawToRepoToAdd(withdraw);
            Clear();
            LinkDataGridViewForWithdraw();

        }

        public void OnWithdrawDoubleClicked(object sender, EventArgs e)
        {

            if (withdrawView.DataGridView.CurrentRow.Index != -1)
            {
                withdraw.WithdrawID = Convert.ToInt32(withdrawView.DataGridView.CurrentRow.Cells["withdrawID"].Value);
                withdraw = services.UpdateSelectedWithdraw(withdraw);
                withdrawView.TxtWithdrawAmount = withdraw.WithdrawAmount.ToString();
                withdrawView.TxtWithdrawDate = withdraw.WithdrawDate.ToShortDateString();
                withdrawView.TxtCategory = withdraw.WithdrawName;

            }
        }

        public void OnWithdrawDeleteButtonClicked(object sender, EventArgs e)
        {
            services.PassWithdrawToRepoToDelete(withdraw);
            LinkDataGridViewForWithdraw();
            Clear();
        }

        public void Clear()
        {
            withdrawView.TxtWithdrawAmount = "";
            withdrawView.TxtWithdrawDate = "";
            withdrawView.TxtCategory = "";
            withdraw.WithdrawID = 0;
        }

        public void LinkDataGridViewForWithdraw()
        {
            withdrawView.DataGridView.DataSource = services.DataSourceForWithdraw();
        }

    }
}

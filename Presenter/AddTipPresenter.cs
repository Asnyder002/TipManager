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
    class AddTipPresenter
    {

        // Private or nah
        private TipManagerModel tipManager;

        // Private or nah
        private TipManagerServices services;

        private IAddTip addTipView;

        private Deposit deposit = new Deposit();

        public AddTipPresenter(IAddTip addTipView, TipManagerModel tipManager, TipManagerServices services)
        {
            this.addTipView = addTipView;
            this.tipManager = tipManager;
            this.services = services;

            addTipView.clearButtonClicked += new EventHandler(OnClearButtonClicked);
            addTipView.addTipLoaded += new EventHandler(OnAddTipLoaded);
            addTipView.saveButtonClicked += new EventHandler(OnSaveButtonClicked);
            addTipView.doubleClicked += new EventHandler(OnDoubleClicked);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            Clear();
        }

        public void OnAddTipLoaded(object sender, EventArgs e)
        {
            Clear();
            LinkDataGridViewForAddTip();
        }

        public void OnSaveButtonClicked(object sneder, EventArgs e)
        {
            deposit.DepositAmount = Decimal.Parse(addTipView.TxtTipAmount.Trim());
            deposit.DepoistDate = DateTime.Parse(addTipView.TxtDate.Trim());
            deposit.HoursWorked = Double.Parse(addTipView.TxtHoursWorked.Trim());
            services.PassDepositToRepoToAdd(deposit);
            Clear();
            LinkDataGridViewForAddTip();
        }

        public void OnDoubleClicked(object sender, EventArgs e)
        {
            
            if(addTipView.DataGridView.CurrentRow.Index != -1)
            {
                deposit.DepositID = Convert.ToInt32(addTipView.DataGridView.CurrentRow.Cells["DepositID"].Value);
                deposit = services.UpdateSelectedDeposit(deposit);
                addTipView.TxtTipAmount = deposit.DepositAmount.ToString();
                addTipView.TxtDate = deposit.DepoistDate.ToShortDateString();
                addTipView.TxtHoursWorked = deposit.HoursWorked.ToString();

            }
        }

        public void Clear()
        {
            addTipView.TxtTipAmount = "";
            addTipView.TxtDate = "";
            addTipView.TxtHoursWorked = "";
            deposit.DepositID = 0;
        }

        public void LinkDataGridViewForAddTip()
        {
            addTipView.DataGridView.DataSource = services.DataSourceForAddTip();
        }

    }
}

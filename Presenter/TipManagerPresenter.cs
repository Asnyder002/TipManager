using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;
using TipManager.Services;
using TipManager.View;
using TipManager.UserControls;
using System.Windows.Forms;

namespace TipManager.Presenter
{
    class TipManagerPresenter
    {
        private ITipManager tipManagerView;
        private IHome homeView;
        private IAddTip addTipView;
        private ITransaction transactionView;

        public TipManagerPresenter(ITipManager tipManagerView, IHome homeView, IAddTip addTipView, ITransaction transactionView)
        {
            this.tipManagerView = tipManagerView;
            this.homeView = homeView;
            this.addTipView = addTipView;
            this.transactionView = transactionView;
            

            tipManagerView.addTipButtonClicked += new EventHandler(OnAddTipButtonClicked);
            tipManagerView.homeButtonClicked += new EventHandler(OnHomeButtonClicked);
            tipManagerView.transactionButtonClicked += new EventHandler(OnTransactionButtonClicked);
        }

        public void OnAddTipButtonClicked(object sender, EventArgs e)
        {
            addTipView.BringControlToFront();
        }

        public void OnHomeButtonClicked(object sender, EventArgs e)
        {
            homeView.BringControlToFront();
        }

        public void OnTransactionButtonClicked(object sender, EventArgs e)
        {
            transactionView.BringControlToFront();
        }

    }
}

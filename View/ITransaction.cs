using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipManager.View
{
    interface ITransaction
    {
        event EventHandler withdrawClearButtonClicked;
        event EventHandler withdrawSaveButtonClicked;
        event EventHandler withdrawDeleteButtonClicked;
        event EventHandler withdrawLoaded;
        event EventHandler withdrawDoubleClicked;

        string TxtWithdrawAmount { get; set; }
        string TxtWithdrawDate { get; set; }
        string TxtCategory { get; set; }
        Object DataGridViewDataSource { get; set; }
        DataGridView DataGridView { get; }

        void BringControlToFront();
    }
}

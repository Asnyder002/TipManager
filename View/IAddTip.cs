using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipManager.View
{
    interface IAddTip
    {
        event EventHandler clearButtonClicked;
        event EventHandler saveButtonClicked;
        event EventHandler addTipLoaded;
        event EventHandler doubleClicked;

        string TxtTipAmount { get; set; }
        string TxtDate { get; set; }
        string TxtHoursWorked { get; set; }
        Object DataGridViewDataSource { get; set; }
        DataGridView DataGridView { get; }

        void BringControlToFront();
    }
}

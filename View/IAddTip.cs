using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipManager.View
{
    interface IAddTip
    {
        event EventHandler clearButtonClicked;
        event EventHandler saveButtonClicked;
        event EventHandler addTipLoaded;

        string TxtTipAmount { get; set; }
        string TxtDate { get; set; }
        string TxtHoursWorked { get; set; }

        void BringControlToFront();
    }
}

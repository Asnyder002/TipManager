using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipManager.View
{
    interface ITipManager
    {
        event EventHandler homeButtonClicked;
        event EventHandler addTipButtonClicked;
        event EventHandler transactionButtonClicked;
        event EventHandler analysisButtonClicked;


    }
}

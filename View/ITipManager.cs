﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipManager.View
{
    interface ITipManager
    {
        string TxtTotal { get; set; }
        string TxtTotalMade { get; set; }
        string TxtTotalSpent { get; set; }
        string TxtTotalHours { get; set; }

    }
}

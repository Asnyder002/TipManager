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

        public AddTipPresenter(IAddTip addTipView, TipManagerModel tipManager, TipManagerServices services)
        {
            this.addTipView = addTipView;
            this.tipManager = tipManager;
            this.services = services;
        }
    }
}

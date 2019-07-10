using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.View;

namespace TipManager.Presenter
{
    class AddTipPresenter
    {
        private IAddTip addTipView;

        public AddTipPresenter(IAddTip view)
        {
            addTipView = view;
        }
    }
}

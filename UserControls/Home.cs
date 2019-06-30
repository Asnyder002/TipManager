using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipManager.View;
using TipManager.Presenter;

namespace TipManager.UserControls
{
    public partial class Home : UserControl, IHome
    {

        
        private HomePresenter presenter;

        public Home()
        {
            InitializeComponent();
        }

        public string TxtTotal { get => totalLabel.Text; set => totalLabel.Text = value; }
        public string TxtTotalMade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalSpent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void Home_Load(object sender, EventArgs e)
        {
            presenter = new HomePresenter(this);
            presenter.DisplayTotal();
        }
    }
}

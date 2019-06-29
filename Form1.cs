using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipManager.View;
using TipManager.Presenter;
using TipManager.UserControls;

namespace TipManager
{
    public partial class Form1 : Form, ITipManager
    {

        private TipManagerPresenter presenter;


        public Form1()
        {
            InitializeComponent();
        }


        public string TxtTotal { get => homeControl.totalLabel.Text ; set => homeControl.totalLabel.Text=value; }
        public string TxtTotalMade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalSpent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        private void Form1_Load(object sender, EventArgs e)
        {
            presenter = new TipManagerPresenter(this);
            //presenter.DisplayTotal();
        }

    }
}

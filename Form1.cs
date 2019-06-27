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

namespace TipManager
{
    public partial class Form1 : Form, ITipManager
    {

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        public string TxtTotal { get => totalLabel.Text ; set => totalLabel.Text=value ; }
        public string TxtTotalMade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalSpent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtTotalHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private TipManagerPresenter presenter;
        private void Form1_Load(object sender, EventArgs e)
        {
            presenter = new TipManagerPresenter(this);
            presenter.DisplayTotal();
        }
    }
}

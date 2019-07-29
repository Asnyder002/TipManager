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
        public event EventHandler homeButtonClicked;
        public event EventHandler addTipButtonClicked;
        public event EventHandler transactionButtonClicked;
        public event EventHandler analysisButtonClicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = addTipButtonClicked;
            handler?.Invoke(this, e);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = homeButtonClicked;
            handler?.Invoke(this, e);
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = transactionButtonClicked;
            handler?.Invoke(this, e);
        }
    }
}

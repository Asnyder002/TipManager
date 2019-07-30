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

namespace TipManager.UserControls
{
    public partial class Transaction : UserControl, ITransaction
    {
        public event EventHandler withdrawClearButtonClicked;
        public event EventHandler withdrawSaveButtonClicked;
        public event EventHandler withdrawDeleteButtonClicked;
        public event EventHandler withdrawLoaded;
        public event EventHandler withdrawDoubleClicked;

        public Transaction()
        {
            InitializeComponent();
        }

        public string TxtWithdrawAmount { get => spentTextBox.Text; set => spentTextBox.Text = value; }
        public string TxtWithdrawDate { get => withdrawDateTextBox.Text; set => withdrawDateTextBox.Text = value; }
        public string TxtCategory { get => categoryTextBox.Text; set => categoryTextBox.Text = value; }
        public object DataGridViewDataSource { get => dataGridViewWithdraw.DataSource; set => dataGridViewWithdraw.DataSource = value; }

        public DataGridView DataGridView => dataGridViewWithdraw;

        public void BringControlToFront()
        {
            this.BringToFront();
        }

        private void SaveButtonWithdraw_Click(object sender, EventArgs e)
        {
            EventHandler handler = withdrawSaveButtonClicked;
            handler?.Invoke(this, e);
        }

        private void DeleteButtonWithdraw_Click(object sender, EventArgs e)
        {
            EventHandler handler = withdrawDeleteButtonClicked;
            handler?.Invoke(this, e);
        }

        private void CancelButtonWithdraw_Click(object sender, EventArgs e)
        {
            EventHandler handler = withdrawClearButtonClicked;
            handler?.Invoke(this, e);
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            EventHandler handler = withdrawLoaded;
            handler?.Invoke(this, e);
        }

        private void DataGridViewWithdraw_DoubleClick(object sender, EventArgs e)
        {
            EventHandler handler = withdrawDoubleClicked;
            handler?.Invoke(this, e);
        }
    }
}

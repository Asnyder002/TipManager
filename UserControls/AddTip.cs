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
    public partial class AddTip : UserControl, IAddTip
    {
        public event EventHandler clearButtonClicked;
        public event EventHandler addTipLoaded;
        public event EventHandler saveButtonClicked;

        public AddTip()
        {
            InitializeComponent();
        }

        public string TxtTipAmount { get => tipTextBox.Text; set => tipTextBox.Text = value; }
        public string TxtDate { get => dateTextBox.Text; set => dateTextBox.Text = value; }
        public string TxtHoursWorked { get => hoursWorkedTextBox.Text; set => hoursWorkedTextBox.Text = value; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = clearButtonClicked;
            handler?.Invoke(this, e);
        }

        private void AddTip_Load(object sender, EventArgs e)
        {
            EventHandler handler = addTipLoaded;
            handler?.Invoke(this, e);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = saveButtonClicked;
            handler?.Invoke(this, e);
        }

        public void BringControlToFront()
        {
            this.BringToFront();
        }
    }
}

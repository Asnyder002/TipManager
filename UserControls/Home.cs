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
        public event EventHandler homeLoaded;

        public Home()
        {
            InitializeComponent();
            new HomePresenter(this);
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            EventHandler handler = homeLoaded;
            handler?.Invoke(this, e);
        }

        public string TxtTotal { get => totalLabel.Text; set => totalLabel.Text = value; }
        public string TxtTotalMade { get => totalMadeLabel.Text; set => totalMadeLabel.Text = value; }
        public string TxtTotalSpent { get => totalSpentLabel.Text; set => totalSpentLabel.Text = value; }
        public string TxtTotalHours { get => totalHoursWorkedLabel.Text; set => totalHoursWorkedLabel.Text = value; }

        

        
    }
}

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
        public AddTip()
        {
            InitializeComponent();
        }

        
    }
}

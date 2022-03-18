using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeichnungen
{
    public partial class FrmWuerfel : Form
    {
        public FrmWuerfel()
        {
            InitializeComponent();
        }

        
        private void cbxShowGoal_CheckedChanged(object sender, EventArgs e)
        {
            pbxGoal.Visible = cbxShowGoal.Checked;
        }

        private void FrmWuerfel_Paint(object sender, PaintEventArgs e)
        {
            // Viel Erfolg ;)
        }
    }
}

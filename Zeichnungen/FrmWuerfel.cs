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
            //Hilfsvariablen
            Graphics g = e.Graphics;
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            //Zeichenmittel
            Pen pen = new Pen(Color.Black, 2);

            //Mitte
            Point om = new Point(w/2, 0);
            Point um = new Point(w/2, h);

            //Mitte links+rechts
            Point lm = new Point(0, h/2);
            Point rm = new Point(w, h/2);

            //links+rechts, mitte, oben
            Point lmo = new Point(0, lm.Y/2);
            Point rmo = new Point(w, lm.Y/2);

            //links+rechts, mitte unten
            Point lmu = new Point(0, lm.Y + lm.Y / 2);
            Point rmu = new Point(w, lm.Y + lm.Y / 2);
 
            //Zeichnungen
            g.DrawLine(pen, om, lmo);
            g.DrawLine(pen, lmo, lm);
            g.DrawLine(pen, lm, lmu);
            g.DrawLine(pen, lmu, um);



        }
    }
}

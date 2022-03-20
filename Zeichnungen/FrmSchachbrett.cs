using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeichnungen
{
    public partial class FrmSchachbrett : Form
    {
        public FrmSchachbrett()
        {
            InitializeComponent();
        }

        
        private void cbxShowGoal_CheckedChanged(object sender, EventArgs e)
        {
            pbxGoal.Visible = cbxShowGoal.Checked;
        }

        private void FrmSchachbrett_Paint(object sender, PaintEventArgs e)
        {
            //Hilfsvariablen
            Graphics g = e.Graphics;
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;

            Brush black = new SolidBrush(Color.Black);
            Brush white = new SolidBrush(Color.White);

            // Ein Schachbrett besteht aus 8x8 Quadraten.
            int anzahlZeilen = 8;
            int anzahlSpalten = 8;

            int breiteZelle = w/anzahlSpalten;
            int hoeheZelle = h/anzahlZeilen;

            bool schwarz = false;

            for (int y = 0; y < anzahlZeilen; y++)
            {
                for (int x = 0; x < anzahlSpalten; x++)
                {
                    //Um die Rechtecke klickbar zu machen, müsste r in einem (mehrdimensionalen) Array abgelegt werden.
                    Rectangle r = new Rectangle(breiteZelle*x, hoeheZelle*y, breiteZelle, hoeheZelle);

                    if (schwarz)
                    {
                        g.FillRectangle(black, r);
                    } else
                    {
                        g.FillRectangle(white, r);
                    }
                    
                    schwarz = !schwarz; 
                }

                schwarz = !schwarz; //Bei Zeilenwechsel muss die Farbe nochmal gewechselt werden.
            }
        }
    }
}

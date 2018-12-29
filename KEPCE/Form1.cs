using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEPCE
{
    public partial class Form1 : Form
    {
        int KonumX = 0, KonumY = 0, KonumX1 = 0, KonumY1 = 0, KonumX2 = 0, KonumY2 = 0;
        public Form1()
        {
            InitializeComponent();
            KonumX = pbxGovde.Location.X;
            KonumY = pbxGovde.Location.Y;
            KonumX1 = pbxKolD3.Location.X;
            KonumY1 = pbxKolD3.Location.Y;
            KonumX2 = pbxKolD2.Location.X;
            KonumY2 = pbxKolD2.Location.Y;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (KonumX < 0 && KonumX1 < 0 && KonumX2 < 0)
            {
                KonumX = 0;
                KonumX1 = 0;
                KonumX2 = 0;
            }
            else if (KonumX < 945 && KonumX1 < 945 && KonumX2 < 945)
            {
                KonumX = 945;
                KonumX1 = 945;
                KonumX2 = 945;
            }
            if (KonumY < 0 && KonumY1 < 0 && KonumY2 < 0)
            {
                KonumY = 0;
                KonumY1 = 0;
                KonumY2 = 0;
            }
            else if (KonumY > 583 && KonumY1 > 583 && KonumY2 > 583)
            {
                KonumY = 300;
                KonumY1 = 300;
                KonumY2 = 300;
            }

            if (e.KeyCode == Keys.Left)
            {
                KonumX = KonumX - 5;
                KonumX1 = KonumX1 - 5;
                KonumX2 = KonumX2 - 5;
                pbxGovde.Left = KonumX;
                pbxKolD3.Left = KonumX1;
                pbxKolD2.Left = KonumX2;
            }
            else if (e.KeyCode == Keys.Right)
            {
                KonumX = KonumX + 5;
                KonumX1 = KonumX1 + 5;
                KonumX2 = KonumX2 + 5;
                pbxGovde.Left = KonumX;
                pbxKolD3.Left = KonumX1;
                pbxKolD2.Left = KonumX2;
            }
            else if (e.KeyCode == Keys.Up)
            {
                KonumY = KonumY - 5;
                KonumY1 = KonumY1 - 5;
                KonumY2 = KonumY2 - 5;
                pbxGovde.Left = KonumY;
                pbxKolD3.Left = KonumY1;
                pbxKolD2.Left = KonumY2;

            }
            else if (e.KeyCode == Keys.Down)
            {
                KonumY = KonumY + 5;
                KonumY1 = KonumY1 + 5;
                KonumY2 = KonumY2 + 5;
                pbxGovde.Left = KonumY;
                pbxKolD3.Left = KonumY1;
                pbxKolD2.Left = KonumY2;
            }
        }
    }
}

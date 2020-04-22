using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmSplashScreen : Form
    {
        int count = 0, buffer = 0;

        public frmSplashScreen()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblCopyright.Location);
            var pos2 = this.PointToScreen(lblHeading.Location);
            var pos3 = this.PointToScreen(lblHeading2.Location);
            pos = pictureBox1.PointToClient(pos);       // copyright
            pos2 = pictureBox1.PointToClient(pos2);     // heading
            pos3 = pictureBox1.PointToClient(pos3);     // heading2

            lblCopyright.Parent = pictureBox1;          // copyright
            lblCopyright.Location = pos;
            lblCopyright.BackColor = Color.Transparent;

            lblHeading.Parent = pictureBox1;           // heading
            lblHeading.Location = pos3;
            lblHeading.BackColor = Color.Transparent;

            lblHeading2.Parent = pictureBox1;           // heading2
            lblHeading2.Location = pos2;    
            lblHeading2.BackColor = Color.Transparent;

            Opacity = 0;
            tmFadeIn.Start();


        }

        private void tmFadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmFadeIn.Stop();
                tmBuffer.Start();
            }
            else
            {
                count++;
                Opacity = count * 0.1;
            }
        }

        private void tmBuffer_Tick(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                tmBuffer.Stop();
                tmFadeOut.Start();
            }
            else
            {
                buffer++;
            }
        }

        private void tmFadeOut_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Calculator_Options newform = new Calculator_Options();
                newform.Show();
                Hide();
                tmFadeOut.Stop();

            }
            else
            {
                count--;
                Opacity = count * 0.1;
            }
        }
    }
}

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
    public partial class frmCalculator_Options : Form
    {
        public frmCalculator_Options()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateDisplay.Text = Convert.ToString(DateTime.Now.Date);
            lblDisplayTime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second; 
        }

        private void btnTypingbasicCalc_Click(object sender, EventArgs e)
        {
            frmTyping_Basic_Calculator_V1 type_Basic_Calculator = new frmTyping_Basic_Calculator_V1();
            type_Basic_Calculator.Show();
            Hide();
        }

        private void btnBasicCalc_Click(object sender, EventArgs e)
        {
            FrmBtnBasicCalculator Btn_Basic_Calculator = new FrmBtnBasicCalculator();
            Btn_Basic_Calculator.Show();
            Hide();
        }
    }
}

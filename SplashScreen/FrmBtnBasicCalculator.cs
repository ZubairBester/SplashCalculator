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
    public partial class FrmBtnBasicCalculator : Form
    {
        public FrmBtnBasicCalculator()
        {
            InitializeComponent();
        }
        double num, ans, sq1 = 0, sqr1 = 0;
        int count;

        public void disable() //disable calculator buttons
        {
            //follow are disable when call we disable() function

            txtDisplay.Enabled = false;
            btnON.Show();                   //It will display
            btnOff.Hide();                  //It will disapear
            btnZero.Enabled = false;
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnPoint.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnEqual.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;


        }

        public void enable() //enabling calculator buttons
        {
            txtDisplay.Enabled = true;
            btnOff.Show();          //It will display
            btnON.Hide();           //it will hide
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnPoint.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnEqual.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //display Zero(0) in textbox when press Zero(0) button
            txtDisplay.Text = txtDisplay.Text + 0;
           
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //display dot(.) in textbox when press dot(.) button
            txtDisplay.Text = txtDisplay.Text + ",";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            //Display One(1) in textbox when press One(1) button
            txtDisplay.Text = txtDisplay.Text + 1;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //display Two(2) in textbox when press Two(2) button
            txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //display Three(3) in textbox when press Three(3) button
            txtDisplay.Text = txtDisplay.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            //display four(4) in textbox when press four(4) button
            txtDisplay.Text = txtDisplay.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            //display five(5) in textbox when press five(5) button
            txtDisplay.Text = txtDisplay.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            //display six(6) in textbox when press six(6) button
            txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            //display seven(7) in textbox when press seven(7) button
            txtDisplay.Text = txtDisplay.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            //display eight(8) in textbox when press eight(8) button
            txtDisplay.Text = txtDisplay.Text + 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            //display nine(9) in textbox when press nine(9) button
            txtDisplay.Text = txtDisplay.Text + 9;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void FrmBtnBasicCalculator_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOff_Click(object sender, EventArgs e) //Off button
        {
            disable(); //It will call disable() FUNCTION 
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            enable(); // it will call enable() method to activate buttons
        }

        public void compute()
        {
            switch (count) // creating switch statement
            {
                case 1:
                    ans = num + double.Parse(txtDisplay.Text);   //it performs addition
                    txtDisplay.Text = ans.ToString();           //convert float into string
                    break;
                case 2:
                    ans = num - double.Parse(txtDisplay.Text);   //it performs substraction
                    txtDisplay.Text = ans.ToString();           //convert float into string
                    break;
                case 3:
                    ans = num * double.Parse(txtDisplay.Text);   //it performs multiplication
                    txtDisplay.Text = ans.ToString();           //convert float into string
                    break;
                case 4:
                    ans = num / double.Parse(txtDisplay.Text);   //it performs division
                    txtDisplay.Text = ans.ToString();           //convert float into string
                    break;
                case 5:
                    
                    //sq1 = num * num;
                    //sqr1 = Math.Sqrt(num);
                    ans = Math.Sqrt(num);
                    txtDisplay.Text = ans.ToString();
                                       
                    break;
                default:
                    break;

            }
        }

        private void btnMultiply_Click(object sender, EventArgs e) //Multiplication
        {
            num = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();     //clear textbox
            txtDisplay.Focus();     //focus on textbox after clearing
            count = 3;              //count store case in switch statement
            lblResult.Text = num.ToString() + " " + "x"; //display text on label
        }

        private void btnPlus_Click(object sender, EventArgs e) //Addition
        {
            num = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();     //clear textbox
            txtDisplay.Focus();     //focus on textbox after clearing
            count = 1;              //count store case in switch statement
            lblResult.Text = num.ToString() + " " + "+"; //display text on label
        }

        private void btnDivide_Click(object sender, EventArgs e) //Division
        {
            num = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();         //Clear textbox
            txtDisplay.Focus();         //focus on textbox after clearing
            count = 4;                  //count store case in switch statement
            lblResult.Text = num.ToString() + " " + "/";  //display text on label

        }

        private void btnMinus_Click(object sender, EventArgs e) //Subtraction
        {

            num = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();         //Clear textbox
            txtDisplay.Focus();         //focus on textbox after clearing
            count = 2;                  //count store case in switch statement
            lblResult.Text = num.ToString() + " " + "-";  //display text on label
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(); //call compute() function to perform such operation +,-,/,*
            lblResult.Text = ""; // clear the text on the label
        }

        private void btnDelete_Click(object sender, EventArgs e) //Backspace
        {
            int intlength = txtDisplay.TextLength - 1;
            string text = txtDisplay.Text;
            txtDisplay.Clear();
            for (int i = 0; i < intlength; i++)
            {
               
                    txtDisplay.Text = txtDisplay.Text + text[i];
               
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            try
            {
                num = double.Parse(txtDisplay.Text);

                txtDisplay.Clear();
                txtDisplay.Focus();
                count = 5;
                lblResult.Text = num.ToString() + " " + "√";
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message + " First Number and then sign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}

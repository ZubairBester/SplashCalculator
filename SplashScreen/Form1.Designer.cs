namespace SplashScreen
{
    partial class frmSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmBuffer = new System.Windows.Forms.Timer(this.components);
            this.tmFadeOut = new System.Windows.Forms.Timer(this.components);
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmFadeIn
            // 
            this.tmFadeIn.Tick += new System.EventHandler(this.tmFadeIn_Tick);
            // 
            // tmBuffer
            // 
            this.tmBuffer.Interval = 999;
            this.tmBuffer.Tick += new System.EventHandler(this.tmBuffer_Tick);
            // 
            // tmFadeOut
            // 
            this.tmFadeOut.Tick += new System.EventHandler(this.tmFadeOut_Tick);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Lime;
            this.lblHeading.Location = new System.Drawing.Point(320, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(121, 16);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Basic Calculator";
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.Lime;
            this.lblHeading2.Location = new System.Drawing.Point(321, 46);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(145, 16);
            this.lblHeading2.TabIndex = 2;
            this.lblHeading2.Text = "Scientific Calculator";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Maroon;
            this.lblCopyright.Location = new System.Drawing.Point(193, 305);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(260, 16);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright © ZLab. All rights reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.money_calculator;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 330);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmFadeIn;
        private System.Windows.Forms.Timer tmBuffer;
        private System.Windows.Forms.Timer tmFadeOut;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label lblCopyright;
    }
}


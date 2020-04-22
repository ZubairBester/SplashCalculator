namespace SplashScreen
{
    partial class frmCalculator_Options
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTypingbasicCalc = new System.Windows.Forms.Button();
            this.btnBasicCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(9, 71);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(542, 24);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Please select the type of calculator you would like to use.";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(375, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(37, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateDisplay.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDisplay.Location = new System.Drawing.Point(89, 27);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDateDisplay.TabIndex = 3;
            this.lblDateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTime.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.Location = new System.Drawing.Point(429, 27);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayTime.TabIndex = 4;
            this.lblDisplayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTypingbasicCalc
            // 
            this.btnTypingbasicCalc.Location = new System.Drawing.Point(92, 132);
            this.btnTypingbasicCalc.Name = "btnTypingbasicCalc";
            this.btnTypingbasicCalc.Size = new System.Drawing.Size(150, 52);
            this.btnTypingbasicCalc.TabIndex = 5;
            this.btnTypingbasicCalc.Text = "Typing basic Calculator";
            this.btnTypingbasicCalc.UseVisualStyleBackColor = true;
            this.btnTypingbasicCalc.Click += new System.EventHandler(this.btnTypingbasicCalc_Click);
            // 
            // btnBasicCalc
            // 
            this.btnBasicCalc.Location = new System.Drawing.Point(283, 132);
            this.btnBasicCalc.Name = "btnBasicCalc";
            this.btnBasicCalc.Size = new System.Drawing.Size(139, 52);
            this.btnBasicCalc.TabIndex = 6;
            this.btnBasicCalc.Text = "Button Basic Calculator";
            this.btnBasicCalc.UseVisualStyleBackColor = true;
            this.btnBasicCalc.Click += new System.EventHandler(this.btnBasicCalc_Click);
            // 
            // frmCalculator_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 218);
            this.Controls.Add(this.btnBasicCalc);
            this.Controls.Add(this.btnTypingbasicCalc);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblheading);
            this.MaximizeBox = false;
            this.Name = "frmCalculator_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateDisplay;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTypingbasicCalc;
        private System.Windows.Forms.Button btnBasicCalc;
    }
}
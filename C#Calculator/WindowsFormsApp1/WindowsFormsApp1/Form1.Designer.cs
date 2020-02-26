namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.edtNum1 = new System.Windows.Forms.TextBox();
            this.edtNum2 = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtNum1
            // 
            this.edtNum1.Location = new System.Drawing.Point(30, 35);
            this.edtNum1.Name = "edtNum1";
            this.edtNum1.Size = new System.Drawing.Size(100, 20);
            this.edtNum1.TabIndex = 1;
            // 
            // edtNum2
            // 
            this.edtNum2.Location = new System.Drawing.Point(30, 62);
            this.edtNum2.Name = "edtNum2";
            this.edtNum2.Size = new System.Drawing.Size(100, 20);
            this.edtNum2.TabIndex = 2;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(167, 105);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(42, 13);
            this.lblAns.TabIndex = 3;
            this.lblAns.Text = "Answer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Subtract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.edtNum2);
            this.Controls.Add(this.edtNum1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edtNum1;
        private System.Windows.Forms.TextBox edtNum2;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button button2;
    }
}


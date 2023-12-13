using System;
using System.Windows.Forms;

namespace TestPasswordStrength
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtPassword;
        private Button btnCheckStrength;
        private Label lblResult;
        private ProgressBar progressBar;
        private Label lblFeedback;
        private Label lblPassword;
        private Label lblStrength;
        private Label lblProgressBar;
        private Label lblFeedbackLabel;

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCheckStrength = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblFeedbackLabel = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // btnCheckStrength
            // 
            this.btnCheckStrength.BackColor = System.Drawing.Color.White;
            this.btnCheckStrength.Location = new System.Drawing.Point(125, 70);
            this.btnCheckStrength.Name = "btnCheckStrength";
            this.btnCheckStrength.Size = new System.Drawing.Size(116, 23);
            this.btnCheckStrength.TabIndex = 6;
            this.btnCheckStrength.Text = "Check Strength";
            this.btnCheckStrength.UseVisualStyleBackColor = false;
            this.btnCheckStrength.Click += new System.EventHandler(this.btnCheckStrength_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 26);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Enter your password:";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(28, 117);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(56, 15);
            this.lblStrength.TabIndex = 4;
            this.lblStrength.Text = "Result: ";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(38, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(96, 26);
            this.lblResult.TabIndex = 5;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar.Location = new System.Drawing.Point(28, 156);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(91, 15);
            this.lblProgressBar.TabIndex = 2;
            this.lblProgressBar.Text = "Strength (%):";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(125, 177);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(116, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // lblFeedbackLabel
            // 
            this.lblFeedbackLabel.AutoSize = true;
            this.lblFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackLabel.Location = new System.Drawing.Point(28, 207);
            this.lblFeedbackLabel.Name = "lblFeedbackLabel";
            this.lblFeedbackLabel.Size = new System.Drawing.Size(73, 15);
            this.lblFeedbackLabel.TabIndex = 0;
            this.lblFeedbackLabel.Text = "Feedback:";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(38, 220);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblFeedbackLabel);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckStrength);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Password Strength Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

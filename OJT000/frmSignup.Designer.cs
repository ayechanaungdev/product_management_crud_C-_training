
namespace OJT000
{
    partial class frmSignup
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.btnSignUpCancel = new System.Windows.Forms.Button();
            this.lblLoginError1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtUserName.Location = new System.Drawing.Point(213, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "パスワード  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblUserName.ForeColor = System.Drawing.Color.Indigo;
            this.lblUserName.Location = new System.Drawing.Point(27, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "ユーザ名 :";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtPassword.Location = new System.Drawing.Point(213, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(172, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSignUp.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.btnSignUp.Location = new System.Drawing.Point(213, 172);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(88, 33);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "サインアップ";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "確認パスワード :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtConPass.Location = new System.Drawing.Point(213, 106);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '#';
            this.txtConPass.Size = new System.Drawing.Size(172, 27);
            this.txtConPass.TabIndex = 2;
            // 
            // btnSignUpCancel
            // 
            this.btnSignUpCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnSignUpCancel.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.btnSignUpCancel.Location = new System.Drawing.Point(113, 172);
            this.btnSignUpCancel.Name = "btnSignUpCancel";
            this.btnSignUpCancel.Size = new System.Drawing.Size(88, 33);
            this.btnSignUpCancel.TabIndex = 4;
            this.btnSignUpCancel.Text = "キャンセル";
            this.btnSignUpCancel.UseVisualStyleBackColor = false;
            this.btnSignUpCancel.Click += new System.EventHandler(this.btnSignUpCancel_Click);
            // 
            // lblLoginError1
            // 
            this.lblLoginError1.AutoSize = true;
            this.lblLoginError1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLoginError1.Location = new System.Drawing.Point(27, 140);
            this.lblLoginError1.Name = "lblLoginError1";
            this.lblLoginError1.Size = new System.Drawing.Size(126, 19);
            this.lblLoginError1.TabIndex = 12;
            this.lblLoginError1.Text = "lblLoginError";
            this.lblLoginError1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblLoginError1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnSignUpCancel);
            this.groupBox1.Controls.Add(this.btnSignUp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConPass);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(85, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "サインアップ";
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "サインアップ";
            this.Load += new System.EventHandler(this.frmSignup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Button btnSignUpCancel;
        private System.Windows.Forms.Label lblLoginError1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
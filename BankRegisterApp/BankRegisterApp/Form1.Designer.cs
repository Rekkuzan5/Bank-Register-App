// Cameron Stapp
// CIS150 Bank Register App
// 4-15-2019

namespace BankRegisterApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInitialDeposit = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.AccountTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithDraw = new System.Windows.Forms.Label();
            this.TxtDeposit = new System.Windows.Forms.TextBox();
            this.TxtWithdraw = new System.Windows.Forms.TextBox();
            this.UpdateAccountButton = new System.Windows.Forms.Button();
            this.OverdraftLabel = new System.Windows.Forms.Label();
            this.NavigationHelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(148, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(148, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Original Deposit:";
            // 
            // TxtInitialDeposit
            // 
            this.TxtInitialDeposit.BackColor = System.Drawing.Color.White;
            this.TxtInitialDeposit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialDeposit.Location = new System.Drawing.Point(368, 258);
            this.TxtInitialDeposit.Name = "TxtInitialDeposit";
            this.TxtInitialDeposit.Size = new System.Drawing.Size(138, 33);
            this.TxtInitialDeposit.TabIndex = 6;
            this.TxtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtInitialDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInitialDeposit_KeyPress);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.LightGray;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.CreateButton.FlatAppearance.BorderSize = 5;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateButton.Location = new System.Drawing.Point(368, 423);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(138, 85);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create Account";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountLbl.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.LightGray;
            this.AccountLbl.Location = new System.Drawing.Point(148, 199);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(222, 36);
            this.AccountLbl.TabIndex = 8;
            this.AccountLbl.Text = "Account Number:";
            this.AccountLbl.Visible = false;
            // 
            // AccountTxtBox
            // 
            this.AccountTxtBox.Enabled = false;
            this.AccountTxtBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTxtBox.Location = new System.Drawing.Point(376, 202);
            this.AccountTxtBox.Name = "AccountTxtBox";
            this.AccountTxtBox.ReadOnly = true;
            this.AccountTxtBox.Size = new System.Drawing.Size(128, 33);
            this.AccountTxtBox.TabIndex = 9;
            this.AccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AccountTxtBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 101);
            this.label4.TabIndex = 10;
            this.label4.Text = "Banking Register";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtName.Location = new System.Drawing.Point(248, 144);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(258, 33);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.LightGray;
            this.lblDeposit.Location = new System.Drawing.Point(242, 384);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(113, 36);
            this.lblDeposit.TabIndex = 11;
            this.lblDeposit.Text = "Deposit:";
            this.lblDeposit.Visible = false;
            // 
            // lblWithDraw
            // 
            this.lblWithDraw.AutoSize = true;
            this.lblWithDraw.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithDraw.ForeColor = System.Drawing.Color.LightGray;
            this.lblWithDraw.Location = new System.Drawing.Point(370, 384);
            this.lblWithDraw.Name = "lblWithDraw";
            this.lblWithDraw.Size = new System.Drawing.Size(140, 36);
            this.lblWithDraw.TabIndex = 12;
            this.lblWithDraw.Text = "Withdraw:";
            this.lblWithDraw.Visible = false;
            // 
            // TxtDeposit
            // 
            this.TxtDeposit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeposit.Location = new System.Drawing.Point(240, 423);
            this.TxtDeposit.Name = "TxtDeposit";
            this.TxtDeposit.Size = new System.Drawing.Size(115, 33);
            this.TxtDeposit.TabIndex = 13;
            this.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDeposit.Visible = false;
            this.TxtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDeposit_KeyPress);
            // 
            // TxtWithdraw
            // 
            this.TxtWithdraw.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWithdraw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtWithdraw.Location = new System.Drawing.Point(376, 423);
            this.TxtWithdraw.Name = "TxtWithdraw";
            this.TxtWithdraw.Size = new System.Drawing.Size(128, 33);
            this.TxtWithdraw.TabIndex = 14;
            this.TxtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtWithdraw.Visible = false;
            this.TxtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtWithdraw_KeyPress);
            // 
            // UpdateAccountButton
            // 
            this.UpdateAccountButton.BackColor = System.Drawing.Color.LightGray;
            this.UpdateAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.UpdateAccountButton.FlatAppearance.BorderSize = 5;
            this.UpdateAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.UpdateAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.UpdateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAccountButton.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateAccountButton.Location = new System.Drawing.Point(52, 423);
            this.UpdateAccountButton.Name = "UpdateAccountButton";
            this.UpdateAccountButton.Size = new System.Drawing.Size(136, 85);
            this.UpdateAccountButton.TabIndex = 15;
            this.UpdateAccountButton.Text = "Update Account";
            this.UpdateAccountButton.UseVisualStyleBackColor = false;
            this.UpdateAccountButton.Visible = false;
            this.UpdateAccountButton.Click += new System.EventHandler(this.UpdateAccountButton_Click);
            // 
            // OverdraftLabel
            // 
            this.OverdraftLabel.AutoSize = true;
            this.OverdraftLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdraftLabel.ForeColor = System.Drawing.Color.Red;
            this.OverdraftLabel.Location = new System.Drawing.Point(114, 312);
            this.OverdraftLabel.Name = "OverdraftLabel";
            this.OverdraftLabel.Size = new System.Drawing.Size(396, 26);
            this.OverdraftLabel.TabIndex = 16;
            this.OverdraftLabel.Text = "Account Overdrawn - No Withdraws Possible";
            this.OverdraftLabel.Visible = false;
            // 
            // NavigationHelpLabel
            // 
            this.NavigationHelpLabel.AutoSize = true;
            this.NavigationHelpLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationHelpLabel.ForeColor = System.Drawing.Color.LightGray;
            this.NavigationHelpLabel.Location = new System.Drawing.Point(268, 511);
            this.NavigationHelpLabel.Name = "NavigationHelpLabel";
            this.NavigationHelpLabel.Size = new System.Drawing.Size(281, 26);
            this.NavigationHelpLabel.TabIndex = 17;
            this.NavigationHelpLabel.Text = "*Use Mouse or Tab to Navigate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(556, 541);
            this.Controls.Add(this.NavigationHelpLabel);
            this.Controls.Add(this.OverdraftLabel);
            this.Controls.Add(this.UpdateAccountButton);
            this.Controls.Add(this.TxtWithdraw);
            this.Controls.Add(this.TxtDeposit);
            this.Controls.Add(this.lblWithDraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AccountTxtBox);
            this.Controls.Add(this.AccountLbl);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TxtInitialDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banking Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInitialDeposit;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.TextBox AccountTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithDraw;
        private System.Windows.Forms.TextBox TxtDeposit;
        private System.Windows.Forms.TextBox TxtWithdraw;
        private System.Windows.Forms.Button UpdateAccountButton;
        private System.Windows.Forms.Label OverdraftLabel;
        private System.Windows.Forms.Label NavigationHelpLabel;
    }
}


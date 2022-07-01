
namespace AccountsApp
{
    partial class AccountForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TbInterestRate = new System.Windows.Forms.TextBox();
            this.TbDailyWithdrawalLimit = new System.Windows.Forms.TextBox();
            this.TbBalance = new System.Windows.Forms.TextBox();
            this.TbClientName = new System.Windows.Forms.TextBox();
            this.TbAccountNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbVisa = new System.Windows.Forms.RadioButton();
            this.RbChecking = new System.Windows.Forms.RadioButton();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.TbInterestRate);
            this.groupBox1.Controls.Add(this.TbDailyWithdrawalLimit);
            this.groupBox1.Controls.Add(this.TbBalance);
            this.groupBox1.Controls.Add(this.TbClientName);
            this.groupBox1.Controls.Add(this.TbAccountNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            this.tbSearch.Location = new System.Drawing.Point(445, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 20);
            this.tbSearch.TabIndex = 12;
            this.BtnSearch.Location = new System.Drawing.Point(600, 16);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.TbInterestRate.Location = new System.Drawing.Point(156, 227);
            this.TbInterestRate.Name = "TbInterestRate";
            this.TbInterestRate.Size = new System.Drawing.Size(118, 20);
            this.TbInterestRate.TabIndex = 10;
            this.TbDailyWithdrawalLimit.Location = new System.Drawing.Point(156, 179);
            this.TbDailyWithdrawalLimit.Name = "TbDailyWithdrawalLimit";
            this.TbDailyWithdrawalLimit.Size = new System.Drawing.Size(118, 20);
            this.TbDailyWithdrawalLimit.TabIndex = 9;
            this.TbBalance.Location = new System.Drawing.Point(156, 131);
            this.TbBalance.Name = "TbBalance";
            this.TbBalance.Size = new System.Drawing.Size(118, 20);
            this.TbBalance.TabIndex = 8;
            this.TbClientName.Location = new System.Drawing.Point(156, 85);
            this.TbClientName.Name = "TbClientName";
            this.TbClientName.Size = new System.Drawing.Size(240, 20);
            this.TbClientName.TabIndex = 7;
            this.TbAccountNumber.Location = new System.Drawing.Point(156, 40);
            this.TbAccountNumber.Name = "TbAccountNumber";
            this.TbAccountNumber.Size = new System.Drawing.Size(118, 20);
            this.TbAccountNumber.TabIndex = 6;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Daily Withdrawal Limit :";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest Rate :";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance :";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name :";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number :";
            this.groupBox2.Controls.Add(this.RbVisa);
            this.groupBox2.Controls.Add(this.RbChecking);
            this.groupBox2.Location = new System.Drawing.Point(543, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type Of Account";
            this.RbVisa.AutoSize = true;
            this.RbVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbVisa.Location = new System.Drawing.Point(18, 55);
            this.RbVisa.Name = "RbVisa";
            this.RbVisa.Size = new System.Drawing.Size(48, 19);
            this.RbVisa.TabIndex = 1;
            this.RbVisa.Text = "Visa";
            this.RbVisa.UseVisualStyleBackColor = true;
            this.RbChecking.AutoSize = true;
            this.RbChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbChecking.Location = new System.Drawing.Point(18, 24);
            this.RbChecking.Name = "RbChecking";
            this.RbChecking.Size = new System.Drawing.Size(76, 19);
            this.RbChecking.TabIndex = 0;
            this.RbChecking.Text = "Checking";
            this.RbChecking.UseVisualStyleBackColor = true;
            this.RbChecking.CheckedChanged += new System.EventHandler(this.RbChecking_CheckedChanged);
            this.BtnCreateAccount.Location = new System.Drawing.Point(569, 309);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(138, 40);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 361);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbInterestRate;
        private System.Windows.Forms.TextBox TbDailyWithdrawalLimit;
        private System.Windows.Forms.TextBox TbBalance;
        private System.Windows.Forms.TextBox TbClientName;
        private System.Windows.Forms.TextBox TbAccountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbVisa;
        private System.Windows.Forms.RadioButton RbChecking;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}


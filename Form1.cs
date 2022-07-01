using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class AccountForm : Form
    {
        private List<Account> accounts;

        public AccountForm()
        {
            InitializeComponent();
            accounts = new List<Account>();
            RbChecking.Checked = true;
        }

        private void RbChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (RbChecking.Checked == true)
            {
                TbDailyWithdrawalLimit.Enabled = true;
                TbInterestRate.Enabled = false;
            }
            else if (RbVisa.Checked == true)
            {
                TbDailyWithdrawalLimit.Enabled = false;
                TbInterestRate.Enabled = true;
            }
        }
        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = null;
                int number = Convert.ToInt32(TbAccountNumber.Text);
                if (TbClientName.Text == string.Empty)
                    throw new Exception("The Client name cannot be empty, please insert a vaild name!");
                string name = TbClientName.Text;
                double balance = Convert.ToDouble(TbBalance.Text);
                if (accounts.Exists(x => x.Number == number))
                {
                    MessageBox.Show("This Account number already exist, Please insert a vaild account number!");
                }
                if (RbChecking.Checked)
                {
                    double withdrawLimit = Convert.ToDouble(TbDailyWithdrawalLimit.Text);
                    account = new CheckingAccount(number, name, balance, withdrawLimit);
                    account.Validate_Checking_Account = true;
                }
                else if (RbVisa.Checked)
                {
                    double interestRate = Convert.ToDouble(TbInterestRate.Text);
                    account = new VisaAccount(number, name, balance, interestRate);
                    account.Validate_Checking_Account = false;
                }
                if (account != null)
                {
                    accounts.Add(account);
                    TbAccountNumber.Text = "";
                    TbClientName.Text = "";
                    TbBalance.Text = "";
                    TbDailyWithdrawalLimit.Text = "";
                    TbInterestRate.Text = "";
                    tbSearch.Text = "";
                    RbChecking.Checked = true;
                    MessageBox.Show("Number of account stored : " + accounts.Count, "Information about Account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = Convert.ToInt32(tbSearch.Text);
                Account account = accounts.Find(x => x.Number == accountNumber);

                if (account != null)
                {
                    TbAccountNumber.Text = account.Number.ToString();
                    TbClientName.Text = account.ClientName;
                    TbBalance.Text = account.Balance.ToString();
                    if (account.Validate_Checking_Account == true)
                    {
                        TbDailyWithdrawalLimit.Text = ((CheckingAccount)account).WithdrawLimit.ToString();
                    }
                    else if (account.Validate_Checking_Account == false)
                    {
                        TbInterestRate.Text = ((VisaAccount)account).InterestRate.ToString();
                    }
                }
                else
                    MessageBox.Show("Account not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

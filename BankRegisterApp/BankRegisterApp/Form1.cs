// Cameron Stapp
// CIS150 Bank Register App
// 4-15-2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRegisterApp
{
    public partial class Form1 : Form
    {
        // customer object
        Customer customer1 = new Customer();

        public Form1()
        {
            InitializeComponent();
            TxtName.Focus();
        }

        // create button method/event
        private void CreateButtonClick(object sender, EventArgs e)
        {
            if (!TxtName.Text.Contains(" "))
            {
                TxtName.Text = "Must Enter Full Name!";
                TxtName.Focus();
            }
            else
            {
                customer1.Name = TxtName.Text;
                customer1.InitialDeposit = double.Parse(TxtInitialDeposit.Text);
                customer1.accountNumberGenerate();
                TxtInitialDeposit.Text = customer1.convertDeposit();
                AccountTxtBox.Text = customer1.AccountNumber.ToString();
                TxtName.Enabled = false;
                TxtInitialDeposit.ReadOnly = true;
                AccountLbl.Show();
                AccountTxtBox.Show();
                lblDeposit.Show();
                TxtDeposit.Show();
                TxtDeposit.Focus();
                lblWithDraw.Show();
                TxtWithdraw.Show();
                UpdateAccountButton.Show();
                CreateButton.Hide();
                TxtDeposit.Focus();
            }
        }

        //  update account button method/event
        private void UpdateAccountButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtDeposit.Text))
            {
                customer1.Deposit = double.Parse(TxtDeposit.Text);
                TxtDeposit.Text = String.Empty;
            }
            else
            {
                TxtDeposit.Text = String.Empty;
            }
            if (!string.IsNullOrWhiteSpace(TxtWithdraw.Text))
            {
                customer1.Withdraw = double.Parse(TxtWithdraw.Text);
                TxtWithdraw.Text = String.Empty;
            }
            else
            {
                TxtWithdraw.Text = String.Empty;
            }

            // Use subExchange method from customer class
            customer1.SubsequentExchange();
            if (customer1.SubsequentExchange() < 0.00)
            {
                OverdraftLabel.Show();
                TxtWithdraw.BackColor = Color.Gray;

                TxtInitialDeposit.ForeColor = Color.Red;
                TxtWithdraw.Enabled = false;
            }
            else if (customer1.SubsequentExchange() >= 0.00)
            {
                OverdraftLabel.Hide();
                TxtWithdraw.BackColor = Color.White;
                TxtInitialDeposit.ForeColor = Color.Black;
                TxtWithdraw.Enabled = true;
            }

            string formattedDeposit = customer1.convertDeposit(); 
            TxtInitialDeposit.Text = string.Format("{0:c}", formattedDeposit);

        }

        // use numbers only
        private void TxtInitialDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        // use numbers only
        private void TxtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        // use numbers only
        private void TxtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }
    }
}

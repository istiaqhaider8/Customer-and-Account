using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_and_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Customer_and_acount_entry_Click(object sender, EventArgs e)
        {
            string name = CustomerInputTextBox.Text;
            string email = EmailInputTextBox.Text;
            string accountNumber = AccountNumberInputTextBox.Text;
            string openingDate = OpeningDateInputTextBox.Text;

            Account account = new Account(accountNumber, openingDate);
            customer = new Customer(name, email, account);


            CustomerInputTextBox.Text = "";
            EmailInputTextBox.Text = "";
            AccountNumberInputTextBox.Text = "";
            OpeningDateInputTextBox.Text = "";

            if(name != null && email != null && accountNumber != null && openingDate != null)
            {
                MessageBox.Show("Customer Added successfully");
            }

        }

        private void deposit_Click(object sender, EventArgs e)
        {
            if(customer == null)
            {
                MessageBox.Show("Customer is Not created yet");
                return;
            }


            double amount = Convert.ToDouble(AccounAddInputTextBox.Text);
            bool isDepositted = customer.Account.Deposit(amount);


            if (isDepositted)
            {
                MessageBox.Show("Depositted" + amount.ToString() + "/-");
                AccounAddInputTextBox.Text = "";
                
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Customer is Not created yet");
                return;
            }

            double amount = Convert.ToDouble(AccounAddInputTextBox.Text);
            bool isWithdrawn = customer.Account.Withdraw(amount);


            if (isWithdrawn)
            {
                MessageBox.Show("Withdrawn" + amount.ToString() + "/-");
                AccounAddInputTextBox.Text = "";
                
            }

        }

        private void show_me_details_Click(object sender, EventArgs e)
        {
            CustomerShowTextBox.Text = customer.Name;
            EmailShowTextBox.Text = customer.Email;


            AccountNumberShowTextBox.Text = customer.Account.AccountNo;
            OpeningShowTextBox.Text = customer.Account.OpeningDate;


            BalanceShowTextBox.Text = customer.Account.Balance.ToString();

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    public enum StatusAccount
    {
        Open,
        Closed
    }
        //Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
        //It should be possible to close an account; operations against a closed account must fail.
        //Remember you are working with money so you should use an appropriate data type for it.
    public class BankAccount
    {
        protected string owner;
        protected string accountNumber;
        protected decimal balance;
        private StatusAccount status;

        public string Owner
        {
            get { return owner; }
            //set { owner = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
           // set { accountNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            //set { balance = value; }
        }
        public StatusAccount Status
        {
            get { return status; }
            set { status = value; }              
            
        }

        public BankAccount (string owner, string accountNumber, decimal balance, StatusAccount status)
        {
            this.owner = owner;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.status = status;
        }
                
        public void WithdrawMoney(decimal amount)
        {
            if (status == StatusAccount.Closed)
            {
                throw new InvalidStatusForActions();
            }
            else
            {
                balance -= amount;
            }
        }

        public void DepositMoney(decimal amount)
        {
            if (status == StatusAccount.Closed)
            {
                throw new InvalidStatusForActions();
            }
            else
            {
                balance += amount;
            }                   
        }        

        public override string ToString()
        {
            return Owner + " has an account that is " + Status + ", number " + AccountNumber + ", with a balance of " + Balance + " monetary units.";
        }

    }
}

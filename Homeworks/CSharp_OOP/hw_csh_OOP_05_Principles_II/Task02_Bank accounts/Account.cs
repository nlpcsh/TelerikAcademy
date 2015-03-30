using System;
using Task02_Bank_accounts.Interfaces;

namespace Task02_Bank_accounts
{
    public abstract class Account : ICalculateInterest
    {
        private Customer holder;
        private decimal balance;
        private decimal interestRate;
        private string accountNumber;
        private DateTime openedAccount;
        private DateTime closedAccount;

        public DateTime ClosedAccount
        {
            get { return closedAccount; }
            protected set { closedAccount = value; }
        }

        public DateTime OpenedAccount
        {
            get { return openedAccount; }
            protected set { openedAccount = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }
        
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        
        public decimal Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public Customer Holder
        {
            get { return holder; }
            set { holder = value; }
        }

        public Account(Customer holder, decimal balance, decimal interestRate)
        {
            this.Balance = balance;
            this.Holder = holder;
            this.InterestRate = interestRate;
            //this.OpenedAccount = DateTime.Now;

            // fix the date to test calculation of interest:
            this.OpenedAccount = DateTime.Parse("2014/01/25");
        }

        public void DepositIntoAccount(decimal moneyToDeposit)
        {
            Balance += moneyToDeposit;
        }

        public abstract void CalculateInterest();

        public override string ToString()
        {
            string accountInfo = string.Format(" Holder: {0} \n Balance: {1:F2} \n Interest rate: {2:F4} per/month \n Date of creation: {3} \n", this.Holder.Name, this.Balance, this.InterestRate, this.OpenedAccount);

            return accountInfo;
        }
    }
}

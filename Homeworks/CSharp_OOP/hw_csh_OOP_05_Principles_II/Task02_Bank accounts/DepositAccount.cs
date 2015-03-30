
namespace Task02_Bank_accounts
{
    using System;
    using Task02_Bank_accounts.Interfaces;

    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer holder, decimal balance, decimal interestRate) : base(holder, balance, interestRate)
        {

        }

        public void WithdrawMoney(decimal moneyToWithdraw)
        {
            Console.WriteLine(" Money to withdraw {0:F2} \n", moneyToWithdraw);
            this.Balance -= moneyToWithdraw; 
        }

        public override void CalculateInterest()
        {
            // calculate time
            var totalTimeOfAccountExistence = DateTime.Now - this.OpenedAccount;

            // get months
            var monthsOfInterest = totalTimeOfAccountExistence.Days / 30;

            if (this.Balance >= 1000)
            {
                var moneyToAdd = monthsOfInterest * this.Balance * this.InterestRate ;

                Console.WriteLine(" For the period of {0} months the interest of the account is: {1:F2}", monthsOfInterest, moneyToAdd);

                this.Balance += moneyToAdd;
            }
            else
            {
                Console.WriteLine(" No interest to calculate - balance is less than 1000!");
            }
        }

        public override string ToString()
        {
            string completeInfo = "Account type: Deposit \n";
            return completeInfo + base.ToString();
        }
    }
}

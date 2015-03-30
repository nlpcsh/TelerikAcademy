
namespace Task02_Bank_accounts
{
    using System;
    using Task02_Bank_accounts.Interfaces;

    class MortgageAccounts : Account
    {
        public MortgageAccounts(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {

        }

        public override void CalculateInterest()
        {
            decimal currentInterest = this.InterestRate;
            // calculate time
            var totalTimeOfAccountExistence = DateTime.Now - this.OpenedAccount;

            // get months
            var monthsOfInterest = totalTimeOfAccountExistence.Days / 30;

            bool hasInterest = false;

            // check if there is a condition for interest to add:
            if ((monthsOfInterest <= 6) && (this.Holder is Individual))
            {
                currentInterest = 0;
                hasInterest = true;
            }
            else if ((monthsOfInterest <= 12) && (this.Holder is Company))
            {
                currentInterest /= 2;
                hasInterest = true;
            }
            else
            {
                Console.WriteLine(" No interest to ADD to the balance! ");
                return;
            }

            if (hasInterest)
            {
                decimal moneyToAdd = monthsOfInterest * this.Balance * currentInterest;


                Console.WriteLine(" For the period of {0} months the interest of the account is: {1:F2}", monthsOfInterest, moneyToAdd);

                this.Balance += moneyToAdd;
            }

        }
        
        public override string ToString()
        {
            string completeInfo = "Account type: Mortgage \n";
            return completeInfo + base.ToString();
        }
    }
}

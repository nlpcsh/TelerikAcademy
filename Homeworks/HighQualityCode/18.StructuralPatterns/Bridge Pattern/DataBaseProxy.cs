namespace ProxyPattern
{
    using System;
    using System.Collections.Generic;

    internal class DataBaseProxy : IDataBase
    {
        private readonly bool userIsAuthorized;

        private DataBase realAccount;

        public DataBaseProxy(string userName, string secretKey)
        {
            // Validate if the user is logged in, if he is legit, if he has rights to see this information and so on...
            if (userName != null && secretKey != null)
            {
                this.userIsAuthorized = true;
            }
        }

        public bool Put(string item)
        {
            if (item.Length < 3)
            {
                Console.WriteLine("Name is too short!");

                return false;
            }

            if (item.Length > 60)
            {
                Console.WriteLine("Name is too long");

                return false;
            }

            if (!this.userIsAuthorized)
            {
                Console.WriteLine("You are not authorized!");
                Console.WriteLine("Redirecting you to login screen...");

                return false;
            }

            this.CheckIfAccountIsActive();

            this.realAccount.Put(item);

            return true;
        }

        public bool Pull(string item)
        {
            // Do validations
            this.CheckIfAccountIsActive();

            this.realAccount.Pull(item);
            return true;
        }

        public List<string> AllNames()
        {
            // Do validations
            this.CheckIfAccountIsActive();

            return this.realAccount.AllNames();
        }

        private void CheckIfAccountIsActive()
        {
            if (this.realAccount == null)
            {
                this.realAccount = new DataBase();
            }
        }
    }
}
namespace ProxyPattern
{
    public class DBManager
    {
        public static void Main()
        {
            IDataBase account = new DataBaseProxy("it's me", "for real");

            DisplayAll(account);
            Push("Be Happy!", account);
            DisplayAll(account);
            Pull("Good morning sunshine!", account);
            DisplayAll(account);
            Push("Be cool!", account);
            DisplayAll(account);
        }

        private static void DisplayAll(IDataBase account)
        {
            for (int i = 0; i < account.AllNames().Count; i++)
            {
                System.Console.WriteLine("{0:C}", account.AllNames()[i]);
            }
        }

        private static void Pull(string name, IDataBase account)
        {
            if (account.Pull(name))
            {
                System.Console.WriteLine("You have this item: {0:C}", name);
            }
        }

        private static void Push(string name, IDataBase account)
        {
            if (account.Put(name))
            {
                System.Console.WriteLine("Item is in the Data Base: {0:C}", name);
            }
        }
    }
}

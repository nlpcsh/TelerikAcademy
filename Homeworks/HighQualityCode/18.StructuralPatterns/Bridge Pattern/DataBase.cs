namespace ProxyPattern
{
    using System.Collections.Generic;

    internal class DataBase : IDataBase
    {
        public DataBase()
        {
            this.ItemsNames = new List<string>();
        }

        private List<string> ItemsNames { get; set; }

        public List<string> AllNames()
        {
            return this.ItemsNames;
        }

        public bool Pull(string name)
        {
            for (int i = 0; i < this.ItemsNames.Count; i++)
            {
                if (this.ItemsNames[i] == name)
                {
                    return true;
                }
            }
     
            return false;
        }

        public bool Put(string name)
        {
            // Do some validations
            this.ItemsNames.Add(name);

            // Adding new name -> successful
            return true;
        }
    }
}
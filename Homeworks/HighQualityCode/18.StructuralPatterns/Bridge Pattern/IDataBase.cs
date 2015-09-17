namespace ProxyPattern
{
    using System.Collections.Generic;

    internal interface IDataBase
    {
        bool Put(string name);

        bool Pull(string name);

        List<string> AllNames();
    }
}
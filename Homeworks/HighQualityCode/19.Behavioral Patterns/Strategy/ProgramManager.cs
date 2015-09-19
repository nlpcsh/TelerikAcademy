namespace Strategy
{
    using System.Collections.Generic;

    public class ProgramManager
    {
        public static void Main()
        {
            ComparerDemo();
            System.Console.WriteLine(new string('-', 60));
            LoggerDemo();
        }

        private static void ComparerDemo()
        {
            var list = new List<int> { 1, 3, 5, 6, 8, 19, 100, 123, 1337 };

            var sorter = new SortDescending(); // SortStrange();

            var someSorter = new ArraySorter(list, sorter);

            someSorter.SortArray();

            foreach (var item in someSorter.ListOfInts)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void LoggerDemo()
        {
            var logger = new ConsoleLogger(); // FileLogger("log.txt"); 

            var doSomethingImportant = new DishWasher(logger);
            doSomethingImportant.WashDishes();
        }
    }
}

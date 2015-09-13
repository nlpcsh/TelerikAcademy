namespace SimpleFactory
{ 
    using System;

    public class TeaFactory
    {
        // Parameter can be string (e.g. from configuration file)
        // Also the method can be static but we won't be able to extend the class
        public Tea GetTea(TeaType teaType)
        {
            // Can also be implemented using dictionary
            switch (teaType)
            {
                case TeaType.Regular:
                    // Can be subtype of Tea
                    return new Tea(0, 150);
                case TeaType.Double:
                    return new Tea(0, 200);
                case TeaType.Milked:
                    return new Tea(100, 100);
                case TeaType.Black:
                    return new Tea(200, 100);
                default:
                    throw new ArgumentException();
            }
        }
    }
}

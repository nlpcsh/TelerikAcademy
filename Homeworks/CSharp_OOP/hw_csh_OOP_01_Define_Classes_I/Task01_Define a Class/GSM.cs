/* Task 1 - Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
    Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 
 Task 2 - Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

 Task 3 - Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
 
 Task 4 - Add a method in the GSM class for displaying all information about it.
    Try to override ToString().
 
 Task 5 - Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
    Ensure all fields hold correct data at any given time.

 Task 6 - Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
 
 Task 7 - Write a class GSMTest to test the GSM class:
   Create an array of few instances of the GSM class.
   Display the information about the GSMs in the array.
   Display the information about the static property IPhone4S.
 
 Task 8 - Create a class Call to hold a call performed through a GSM.
   It should contain date, time, dialled phone number and duration (in seconds).

 Task 9 - Add a property CallHistory in the GSM class to hold a list of the performed calls.
   Try to use the system class List<Call>.
 
 Task 10 - Add methods in the GSM class for adding and deleting calls from the calls history.
   Add a method to clear the call history
 
 Task 11 - Add a method that calculates the total price of the calls in the call history.
   Assume the price per minute is fixed and is provided as a parameter.
 
 Task 12 - Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
  Create an instance of the GSM class.
  Add few calls.
  Display the information about the calls.
  Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
  Remove the longest call from the history and calculate the total price again.
  Finally clear the call history and print it.

 */

namespace HW01_Define_a_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    class GSM
    {
        private string model;
        private string manufacturer;
        private double price = 0;
        private string owner = "NA";

        public static string iPhone4S = "iPhone-4S is a phone that has been released in 2011 with iOS version 5.0.";

        private Battery batteryModel;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model name cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model name too short! It should be at least 2 letters");
                }

                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Manufacturer name too short! It should be at least 2 letters");
                }

                this.manufacturer = value;
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("The cell phone is priceless!");
                }

                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner name cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Owner name too short! It should be at least 2 letters");
                }
                foreach (char ch in value)
                {
                    if (!IsLetterAllowedInNames(ch))
                    {
                        throw new ArgumentException("Invalid owner's name! Use only letters, space and hyphen");
                    }
                }
                this.owner = value;
            }
        }
        public string IPhone4S
        {
            get
            {
                return this.IPhone4S;
            }
            set
            {
                this.IPhone4S = value;
            }
        }
        public Battery BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public Display CellDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }


        public GSM() : this (string.Empty, string.Empty,  0, string.Empty)
        {
            ;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }


        public void DisplayGSMInfo()
        {
            Console.WriteLine(" Manifacturer       : {0} ", this.Manufacturer);
            Console.WriteLine(" Model              : {0} ", this.Model);
            Console.WriteLine(" Price              : {0} ", this.Price);
            Console.WriteLine(" Ownder             : {0} ", this.Owner);
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}", this.Model, this.Manufacturer, this.Price);
        }

        public void AddToHistory(Call callHist)
        {
            this.callHistory.Add(callHist);
        }

        public void RemoveHistory(Call call)
        {
            int index = this.callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
        }

        public void ViewHistory(int intexOfHistory)
        {
            this.callHistory[intexOfHistory].CallInfo();
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculatePriceOfCalls(double callPrice)
        {
            decimal totalPrice = 0;

            foreach (var item in callHistory)
            {
                totalPrice += (decimal)(item.Duration * callPrice);
            }

            return totalPrice;
        }

        private bool IsLetterAllowedInNames(char ch)
        {
            bool isAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }
    }
}

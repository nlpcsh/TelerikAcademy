namespace Methods
{
    using System;
    using System.Globalization;
    
    internal class Student
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string town;
        private string otherInfo;

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string dateOfBirth, string town, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Town = town;
        }

        public string FirstName 
        {
            get 
            {
                return this.firstName;
            }

            set
            {
                if (this.CheckInputString(value, "FistName", 2, 20))
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.CheckInputString(value, "LastName", 2, 20))
                {
                    this.lastName = value;
                }
            }
        }

        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                if (this.CheckInputString(value, "DateOfBirth", 10, 10))
                {
                    try
                    {
                        byte days = byte.Parse(value.Substring(0, 2));

                        if (days < 1 || 31 < days)
                        {
                            throw new ArgumentException("Days are not in the correct value interval");
                        }
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("Days are not a numbers!");
                    }

                    try
                    {
                        byte months = byte.Parse(value.Substring(3, 2));

                        if (months < 1 || 12 < months)
                        {
                            throw new ArgumentException("Months are not in the correct value interval");
                        }
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("Months are not a numbers!");
                    }

                    try
                    {
                        int year = int.Parse(value.Substring(6, 4));

                        if ((year < DateTime.Now.Year - 150) || (DateTime.Now.Year < year))
                        {
                            throw new ArgumentException("Year is not in the correct value interval");
                        }
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("Year is not a number!");
                    }

                    this.dateOfBirth = value;
                }
            }
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (this.CheckInputString(value, "Town", 3, 20))
                {
                    this.town = value;
                }
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (this.CheckInputString(value, "OtherInfo", 3, 500))
                {
                    this.otherInfo = value;
                }
            }
        }

        public bool IsOlderThan(Student student)
        {
            DateTime firstDate = DateTime.ParseExact(this.DateOfBirth, "dd.mm.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(student.DateOfBirth, "dd.mm.yyyy", CultureInfo.InvariantCulture);

            bool firstIsOlder = firstDate < secondDate;

            return firstIsOlder;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + ", born at " + this.DateOfBirth + ", from " + this.Town + ", other info: " + this.OtherInfo);
        }

        private bool CheckInputString(string text, string variable, int minLengthOfText, int maxLengthOfText)
        {
            if (text == string.Empty)
            {
                throw new ArgumentNullException(variable + " should be not NULL!");
            }

            if (text.Length < minLengthOfText)
            {
                throw new ArgumentException(string.Format("{0} should be more than {1} character!", variable, minLengthOfText));
            }

            if (text.Length > maxLengthOfText)
            {
                throw new ArgumentException(string.Format("{0} should NOT be more than {1} character!", variable, maxLengthOfText));
            }

            return true;
        }
    }
}

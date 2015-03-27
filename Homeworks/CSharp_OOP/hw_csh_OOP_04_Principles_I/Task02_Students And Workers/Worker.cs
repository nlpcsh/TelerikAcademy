
namespace Task02_Students_And_Workers
{
    using System;

    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public Worker(string fName, string lName, decimal hperDay, decimal weekSalary)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.WorkHoursPerDay = hperDay;
            this.WeekSalary = weekSalary;
        }

        public decimal MoneyPerHour()
        {
            return weekSalary / (5 * workHoursPerDay);
        }

    }
}

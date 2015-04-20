namespace StudentsAndWorkers
{
    using System;
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Working hours must be > 0");
                }
                this.workHoursPerDay = value; 
            }
        }
        
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Weekly salary must be > 0");
                }
                this.weekSalary = value; 
            }
        }

         public double MoneyPerHour()
        {
            double moneyPerHour = (this.weekSalary / 5) / this.workHoursPerDay;
            return moneyPerHour;
        }
    }
}

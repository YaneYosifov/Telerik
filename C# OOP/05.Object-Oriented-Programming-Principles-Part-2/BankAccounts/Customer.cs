namespace BankAccounts
{
    using System;
    public abstract class Customer
    {
        private string name;

        public Customer(string name, string customerNumber)
        {
            this.Name = name;
            this.CustomerNumber = customerNumber;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value; 
            }
        }

        public string CustomerNumber { get; private set; }
    }
}

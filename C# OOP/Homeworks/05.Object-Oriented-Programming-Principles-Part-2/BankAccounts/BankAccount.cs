namespace BankAccounts
{
    using System;
    public abstract class BankAccount : IDepositable
    {
        protected decimal balance;
        protected decimal interestRate;

        protected BankAccount(decimal balance, decimal interest, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance
        {
            get { return this.balance; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be less than 0");
                }
                this.balance = value; 
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be less than 0");
                }
                this.interestRate = value; 
            }
        }

        public Customer Customer { get; private set; }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (this.InterestRate / 100) * months;
        }

        public abstract void Deposit(decimal amount);
    }
}

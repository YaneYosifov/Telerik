namespace BankAccounts
{
    using System;

    public class LoanAccount : BankAccount, IDepositable
    {
        public LoanAccount(decimal balance, decimal interest, Customer customer)
            : base(balance, interest, customer)
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative");
            }

            if (this.Balance > amount)
            {
                this.Balance -= amount;
            }
            else
            {
                this.Balance = 0;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be less than 0");
            }

            if ((this.Customer is Individual && months <= 3) || (this.Customer is Company && months <= 2))
            {
                return 0;
            }

            return this.Balance * (this.InterestRate / 100) * (months - (Customer is Individual ? 3 : 2));
        }
    }
}

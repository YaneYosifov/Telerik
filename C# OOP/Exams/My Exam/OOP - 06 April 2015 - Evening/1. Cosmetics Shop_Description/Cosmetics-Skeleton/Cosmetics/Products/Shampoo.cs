namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                Validator.CheckIfNull(this.milliliters, GlobalErrorMessages.ObjectCannotBeNull);
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            private set
            {
                this.usage = value;
            }
        }
    }
}

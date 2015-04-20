namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(this.name, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(this.name, 10, 3, GlobalErrorMessages.InvalidStringLength);
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(this.brand, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(this.brand, 10, 2, GlobalErrorMessages.InvalidStringLength);
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                Validator.CheckIfNull(this.price, GlobalErrorMessages.ObjectCannotBeNull);
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }
        }

        public string Print()
        {
            throw new System.NotImplementedException();
        }
    }
}

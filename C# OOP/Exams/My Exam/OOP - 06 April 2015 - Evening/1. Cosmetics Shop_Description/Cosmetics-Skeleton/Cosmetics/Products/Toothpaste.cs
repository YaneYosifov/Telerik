namespace Cosmetics.Products
{
    using System.Collections.Generic;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = new List<string>();
        }

        string IToothpaste.Ingredients
        {
            get { return new List<string>(this.ingredients).ToString(); }
            private set
            {
                Validator.CheckIfStringLengthIsValid(this.ingredients.ToString(), 12, 4, GlobalErrorMessages.InvalidStringLength);
            }
        }
    }
}

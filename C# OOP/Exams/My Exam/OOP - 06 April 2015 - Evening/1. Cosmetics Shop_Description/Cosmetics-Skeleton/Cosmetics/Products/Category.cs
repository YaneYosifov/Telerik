namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : Product, IToothpaste, ICategory
    {
        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name, string brand, decimal price, GenderType gender)
            : base(name, brand, price, gender)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
        }
        public Category(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
            this.Ingredients = ingredients.ToString();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(this.name, 15, 2, GlobalErrorMessages.InvalidStringLength);
                Validator.CheckIfStringIsNullOrEmpty(this.name, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                this.name = value;
            }
        }

        public string Ingredients
        {
            get { return this.Ingredients; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(this.Ingredients, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                this.Ingredients = value;
            }
        }

        public ICollection<IProduct> Cosmetics
        {
            get
            {
                return new List<IProduct>(this.cosmetics);
            }
        }

        public void AddCosmetics(IProduct cosmetic)
        {
            this.cosmetics.Add(cosmetic);
            this.cosmetics.OrderBy(a => a.Brand).OrderByDescending(b => b.Price);
        }

        public void RemoveCosmetics(IProduct cosmetic)
        {
            this.cosmetics.Remove(cosmetic);
        }

        public string Print()
        {
            return string.Format(
                    "{0} category – {1} products/product in total" +
                    "- {2} – {3}:" +
                    "  * Price: ${4}" +
                    "  * For gender: {5}" +
                    "  * Ingredients: { }" +
                    "- {2} – {3}:" +
                    "  * Price: ${4}" +
                    "  * For gender: {5}" +
                    "  * Quantity: { }" +
                    "  * Usage: EveryDay/Medical (when applicable)",
                    this.GetType().Name, this.Cosmetics.Count, this.Brand, this.Name, this.Price, this.Gender
                    /*string.Join(", " this.Ingredients)*, this.GetUsage(command.Parameters[5])*/);        
        }
    }
}

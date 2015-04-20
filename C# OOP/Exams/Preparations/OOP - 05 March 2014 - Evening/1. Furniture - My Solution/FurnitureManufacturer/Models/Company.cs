namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name must be at least 5 symbols long");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols");
                }

                for (int i = 0; i < 10; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Registration number must contain only digits");
                    }
                }

                this.registrationNumber = value;
            }
        }

        public System.Collections.Generic.ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            return string.Format("{0} - {1} - {2} {3}",
            this.Name,
            this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        }
    }
}

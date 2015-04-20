namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private MaterialType material;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            { 
                return this.model; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model must be at least 3 symbols long");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get { return this.material.ToString(); }
        }

        public decimal Price
        {
            get
            { 
                return this.price; 
            }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("Price must be greater than 0.00");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get 
            { 
                return this.height; 
            }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("Height must be greater than 0.00");
                }
                this.height = value;
            }
        }
    }
}

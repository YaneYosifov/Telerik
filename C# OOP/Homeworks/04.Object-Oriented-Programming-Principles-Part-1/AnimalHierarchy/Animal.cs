namespace Animals
{
    using System;
    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0");
                }
                this.age = value; 
            }
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

        public Sex Sex { get; protected set; }

        public abstract void ProduceSound();
    }
}

namespace Animals.Cats
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }
        public Cat(int age, string name)
            : base(age, name)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("{0} is mewing", this.Name);
        }
    }
}

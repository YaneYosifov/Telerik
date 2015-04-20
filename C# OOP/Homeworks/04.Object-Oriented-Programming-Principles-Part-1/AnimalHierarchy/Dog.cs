namespace Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("{0} is barking", this.Name);
        }
    }
}

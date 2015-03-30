namespace Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Sex sex) 
            : base(age, name, sex)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("{0} is kwaking", this.Name);
        }
    }
}

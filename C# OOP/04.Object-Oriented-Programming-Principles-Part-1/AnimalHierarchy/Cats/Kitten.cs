namespace Animals.Cats
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.Female;
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("{0} is mewing", this.Name);
        }
    }
}

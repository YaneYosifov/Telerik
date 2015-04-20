namespace Animals.Cats
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.Male;
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("{0} is mewing", this.Name);
        }
    }
}

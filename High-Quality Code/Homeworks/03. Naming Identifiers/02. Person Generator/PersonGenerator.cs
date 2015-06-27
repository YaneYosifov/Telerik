namespace PersonGenerator
{
    public class PersonGenerator
    {
        public void MakePerson(int number)
        {
            Person person = new Person();
            person.Age = number;
            if (number % 2 == 0)
            {
                person.Name = "Iron Man";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Wonder Woman";
                person.Gender = Gender.Female;
            }
        }
    }
}
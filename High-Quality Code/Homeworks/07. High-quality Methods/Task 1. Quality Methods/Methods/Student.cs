namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate;
            DateTime secondDate;

            bool isValidFirstDate = DateTime.TryParse(other.OtherInfo.Substring(other.OtherInfo.Length - 10), out firstDate);
            bool isValidSecondDate = DateTime.TryParse(this.OtherInfo.Substring(this.OtherInfo.Length - 10), out secondDate);

            if (!(isValidFirstDate && isValidSecondDate))
            {
                throw new FormatException("Invalid DateTime format.");
            }

            return firstDate > secondDate;
        }
    }
}

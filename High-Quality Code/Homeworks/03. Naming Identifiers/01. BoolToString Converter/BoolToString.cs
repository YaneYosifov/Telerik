namespace BoolToStringConverter
{
    using System;

    public class BoolToString
    {
        public void ConvertBoolToString(bool isTrue)
        {
            string word = isTrue.ToString();
            Console.WriteLine(word);
        }
    }
}
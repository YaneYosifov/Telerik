namespace Calendar
{
    using System;
    using System.IO;

    internal static class Message
    {
        private static void Main()
        {
            var debugDir = Directory.GetCurrentDirectory();
            var projectDir = Directory.GetParent(Directory.GetParent(debugDir).ToString());
            Console.WriteLine("CurrentMonth.html created in {0}", projectDir);
        }
    }
}

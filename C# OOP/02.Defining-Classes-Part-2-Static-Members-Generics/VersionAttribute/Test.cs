/* Problem 11. Version attribute
 * Apply the version attribute to a sample class and display its version at runtime.
 */

namespace VersionAttribute
{
    using System;

    [VersionAttribute("2.10")]
    class TestProgram
    {
        static void Main()
        {
            Type type = typeof(TestProgram);

            var attribute = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Version[{0}.{1}]", item.Major, item.Minor);
            }
        }
    }
}
/* Problem 17. Longest string
 * Write a program to return the string with maximum length from an array of strings.
 * Use LINQ.
 */

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            List<string> strList = new List<string>() 
            {
                "Lorem ipsum dolor sit amet, unum illum scriptorem an sea, ex vim novum civibus accusata.",
                "Tota corpora legendos vix an.",
                "Erat sonet percipitur ad duo, habeo mundi appellantur ius ex, ea ius recteque dissentias.",
                "Eligendi insolens an duo, eripuit ornatus eos cu, pro atqui munere in."
            };

            var longest = strList.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
        }
    }
}

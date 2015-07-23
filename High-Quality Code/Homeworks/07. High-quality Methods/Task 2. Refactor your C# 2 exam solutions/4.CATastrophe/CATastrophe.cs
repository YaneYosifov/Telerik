namespace TelerikCSharp2Exam
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class CATastrophe
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string[] code = new string[lines];
            for (int i = 0; i < lines; i++)
            {
                code[i] = Console.ReadLine();
            }

            List<string> varsInMethods = new List<string>();
            List<string> varsInLoops = new List<string>();
            List<string> varsInConditionalStatements = new List<string>();
            for (int i = 0; i < code.Length; i++)
            {
                int scopeStart = i + 2;
                if (code[i].Contains("static"))
                {
                    ExtractMatches(code[i], varsInMethods);
                    ExtractMatchesInScope(code, varsInMethods, scopeStart);
                }

                if (code[i].Contains("for") || code[i].Contains("foreach") || code[i].Contains("while"))
                {
                    ExtractMatches(code[i], varsInLoops);
                    ExtractMatchesInScope(code, varsInLoops, scopeStart);
                }

                if (code[i].Contains("if") || code[i].Contains("else"))
                {
                    ExtractMatchesInScope(code, varsInConditionalStatements, scopeStart);
                }
            }

            PrintVarsList(varsInMethods, "Methods");
            PrintVarsList(varsInLoops, "Loops");
            PrintVarsList(varsInConditionalStatements, "Conditional Statements");
        }

        private static void ExtractMatches(string codeLine, List<string> varsList)
        {
            string[] primitiveTypes = { "char", "string", "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", "bool" };
            foreach (var primitiveType in primitiveTypes)
            {
                string pattern = Regex.Escape(primitiveType) + @"\s*\??\s+([a-z]\w*)";
                foreach (Match match in Regex.Matches(codeLine, pattern))
                {
                    varsList.Add(match.Groups[1].Value);
                }
            }
        }

        private static void ExtractMatchesInScope(string[] code, List<string> varsList, int startLine)
        {
            int openedBrackets = 0;
            for (int j = startLine; openedBrackets != -1; j++)
            {
                if (code[j + 1].Contains("{"))
                {
                    openedBrackets++;
                }

                if (openedBrackets == 0)
                {
                    ExtractMatches(code[j], varsList);
                }

                if (code[j + 1].Contains("}"))
                {
                    openedBrackets--;
                }
            }
        }

        private static void PrintVarsList(List<string> varslist, string varsListName)
        {
            if (varslist.Count != 0)
            {
                Console.WriteLine("{0} -> " + varslist.Count + " -> " + string.Join(", ", varslist), varsListName);
            }
            else
            {
                Console.WriteLine("{0} -> None", varsListName);
            }
        }
    }
}

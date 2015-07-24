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

            PrintVars(varsInMethods, "Methods");
            PrintVars(varsInLoops, "Loops");
            PrintVars(varsInConditionalStatements, "Conditional Statements");
        }

        private static void ExtractMatches(string lineOfCode, List<string> vars)
        {
            string[] primitiveTypes = { "char", "string", "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", "bool" };
            foreach (var primitiveType in primitiveTypes)
            {
                string pattern = Regex.Escape(primitiveType) + @"\s*\??\s+([a-z]\w*)";
                foreach (Match match in Regex.Matches(lineOfCode, pattern))
                {
                    vars.Add(match.Groups[1].Value);
                }
            }
        }

        private static void ExtractMatchesInScope(string[] code, List<string> vars, int lineInScope)
        {
            int openedBrackets = 0;
            while (openedBrackets != -1)
            {
                if (code[lineInScope + 1].Contains("{"))
                {
                    openedBrackets++;
                }

                if (openedBrackets == 0)
                {
                    ExtractMatches(code[lineInScope], vars);
                }

                if (code[lineInScope + 1].Contains("}"))
                {
                    openedBrackets--;
                }

                lineInScope++;
            }
        }

        private static void PrintVars(List<string> vars, string scopeName)
        {
            if (vars.Count != 0)
            {
                Console.WriteLine("{0} -> " + vars.Count + " -> " + string.Join(", ", vars), scopeName);
            }
            else
            {
                Console.WriteLine("{0} -> None", scopeName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Interpreter.Expressions;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumeral = "MMXVII";
            var context = new Context { Input = romanNumeral };

            // Build the parse tree
            var tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (var e in tree)
            {
                e.Interpret(context);
            }

            System.Console.WriteLine($"{romanNumeral} value is {context.Output}");
        }
    }
}

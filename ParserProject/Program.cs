using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserProject
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            Console.WriteLine("HItest");

            //List<string[]> tokens = new List<string[]>();

            //// Add tokens to the list with switched positions
            //tokens.Add(new string[] { "read", "READ" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { ";", "SEMICOLON" });
            //tokens.Add(new string[] { "if", "IF" });
            //tokens.Add(new string[] { "0", "NUMBER" });
            //tokens.Add(new string[] { "<", "LESSTHAN" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { "then", "THEN" });
            //tokens.Add(new string[] { "fact", "IDENTIFIER" });
            //tokens.Add(new string[] { ":=", "ASSIGN" });
            //tokens.Add(new string[] { "1", "NUMBER" });
            //tokens.Add(new string[] { ";", "SEMICOLON" });
            //tokens.Add(new string[] { "repeat", "REPEAT" });
            //tokens.Add(new string[] { "fact", "IDENTIFIER" });
            //tokens.Add(new string[] { ":=", "ASSIGN" });
            //tokens.Add(new string[] { "fact", "IDENTIFIER" });
            //tokens.Add(new string[] { "*", "MULT" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { ";", "SEMICOLON" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { ":=", "ASSIGN" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { "-", "MINUS" });
            //tokens.Add(new string[] { "1", "NUMBER" });
            //tokens.Add(new string[] { "until", "UNTIL" });
            //tokens.Add(new string[] { "x", "IDENTIFIER" });
            //tokens.Add(new string[] { "=", "EQUAL" });
            //tokens.Add(new string[] { "0", "NUMBER" });
            //tokens.Add(new string[] { ";", "SEMICOLON" });
            //tokens.Add(new string[] { "write", "WRITE" });
            //tokens.Add(new string[] { "fact", "IDENTIFIER" });
            //tokens.Add(new string[] { "end", "END" });



            //Parser parser = new Parser(tokens);


            //try
            //{
            //    parser.PrintTree();
            //    Console.WriteLine("Parsing and printing successful!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Parsing failed: " + ex.Message);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNumsCSharp1
{
    internal class Program
    {
        static string FILENAME = "mynums.txt";
        static void Main(string[] args)
        {
            WelcomeMessage();
            List<int> ints = ReadFile();

            Console.Write("Enter a menu item: ");
            string userinput = Console.ReadLine();

            while(userinput != "x")
            {
                if (userinput == "list")
                {
                    foreach (int num in ints)
                    {
                        Console.WriteLine(num);
                    }
                }
                Console.Write("Enter a menu item (x to exit): ");
                userinput = Console.ReadLine();
               
            }
            Console.ReadLine();




        }

        private static List<int> ReadFile()
        {
            List<int> list = new List<int>();
            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText(FILENAME);
                while (!inputFile.EndOfStream)
                {
                    list.Add(int.Parse(inputFile.ReadLine()));

                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        static private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Kodey's favorite numbers");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("list - See all saved numbers\n" +
                "add - Add a new number\n" +
                "random - Randomize list");
            Console.WriteLine("-----------------------------------");

        }

    }
}

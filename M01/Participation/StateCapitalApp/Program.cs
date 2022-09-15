using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCapitalApp
{
    internal class Program //Private class called Program
    {
        static void Main(string[] args) //Declares the main module
        {
            Console.WriteLine(); //Prints blank line
            Console.WriteLine(); //Prints blank lineZ
            Console.Write("Please enter a state and I will return the capital (x to exit): "); //Asks the user for a state to look up and x is exit

            string userinput = Console.ReadLine(); //reads the user input and puts it into a string variable userinput

            while (true) //while loop until it breaks (user puts in x breaks it)
            {
                if (userinput == "x") break; //Break the loop if they type in x
                StateCapital stateCapital = new StateCapital(); //Calls the StateCapital class found in the other file and called it the stateCapital function
                string capital = stateCapital.FindCapital(userinput); //Calls the FindCapital module found in the stateCapital class we just called
                Console.WriteLine(capital); //prints the capital out to the user

                Console.Write("Please enter a state and I will return the capital (x to exit): "); //asks for another state for us to find the capital for
                userinput = Console.ReadLine(); //Gets the user's input and puts it into userinput
            }
        }
    }
}

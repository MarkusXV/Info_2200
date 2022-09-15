using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCityApp
{
    internal class Program //Private class called Program
    {
        static void Main(string[] args) //Declares the main module
        {
            Console.WriteLine(); //Prints blank line
            Console.WriteLine(); //Prints blank line
            Console.Write("Please enter a college and I will return the city (x to exit, random to get a Random College/City)\nCollege: ");
            //Asks the user for a state to look up; x is exit and random is random college

            string userinput = Console.ReadLine(); //reads the user input and puts it into a string variable userinput

            while (true) //while loop until it breaks (user puts in x breaks it)
            {
                if (userinput == "x") break; //Break the loop if they type in x

                if (userinput.ToLower() == "random") //if the userinput is random, continue. Else runs for if it isn't x or random
                {
                    CollegeCity collegecity = new CollegeCity(); //Pulls the public class from the other file and calls the class collegecity
                    string randcollege = collegecity.RandomCollege(); //Calls the RandomCollege module and puts it into a string randcollege
                    string city = collegecity.FindCity(randcollege); //Calls the FindCity module and puts the return into string city

                    Console.WriteLine($"Random College: {randcollege}, City: {city}"); //Writes the random college and the city to the console

                    Console.WriteLine(); //Prints blank line
                    Console.Write("Please enter a college and I will return the city (x to exit, random to get a Random College/City)\nCollege: ");
                    //asks for another state for us to find the capital for
                    userinput = Console.ReadLine(); //Gets the user's input and puts it into userinput

                }
                else //runs if the input isn't x or random
                {
                    CollegeCity collegeCity = new CollegeCity(); //Calls the public class found in the other file and called it collegecity
                    string city = collegeCity.FindCity(userinput); //Calls the FindCapital module found in the stateCapital class we just called

                    if (city != $"No results were found for {userinput}") //if city is found, continue
                    {
                        Console.WriteLine($"The city of {userinput} is {city}"); //prints the capital out to the user
                    }
                    else //runs if the city wasn't found and outputs that to the console
                    {
                        Console.WriteLine($"No results were found for {userinput}"); //Writes to the console that it wasn't found
                    }

                    Console.WriteLine(); //Prints blank line
                    Console.Write("Please enter a college and I will return the city (x to exit, random to get a Random College/City)\nCollege: ");
                    //asks for another state for us to find the capital for
                    userinput = Console.ReadLine(); //Gets the user's input and puts it into userinput
                }
            }
        }
    }
}

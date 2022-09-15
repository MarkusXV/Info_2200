//Grabs the functions from those places so we can use them
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCityApp //Declares the namespace CollegeCityApp
{
    public class CollegeCity //Declares the public class where we have the dictionary available publicly
    {
        List<string> CollegeCityList = new List<string>(); //defines the empty list
        Dictionary<string, string> CollegeCityDictionary = new Dictionary<string, string>(); //Creates an empty dictionary

        public CollegeCity() //Creates the CollegeCity method available publicly
        {
            StreamReader inputFile; //opens the text file to be read

            try // try catch to catch any errors that could come up
            {
                inputFile = File.OpenText("collegecity.txt"); //puts the text into the inputFile variable
                while (!inputFile.EndOfStream) //While loop until there's no more lines in the stream
                {
                    string college_city = inputFile.ReadLine(); //Reads the current line and inputs it into the college_city variable
                    string[] tempCC = college_city.Split(','); //splits the college_city variable by comma and puts it into the tempCC variable
                    CollegeCityList.Add(college_city); //Adds the current college_city line to the list
                    CollegeCityDictionary.Add(tempCC[0], tempCC[1]); //Adds the individual colleges and cities into the dictionary (college = 0, city = 1)
                }
                inputFile.Close(); //Closes the text file
            }
            catch (Exception ex) //catches any errors when trying to read and input the text file into the dictionary
            {
                Console.WriteLine(ex.Message); //displays the error found
            }
        }

        public string FindCity(string college) //Declares a new Method called FindCity available publicly
        {
            if (CollegeCityDictionary.TryGetValue(college, out string city)) //tries to get the value from the dictionary
            {
                return city; //if it finds it, then returns the city to the method
            }
            else //if it can't find the college in the dictionary
            {
                return $"No results were found for {college}"; //if it doesn't, display that we couldn't find the college in the dictionary
            }
        }
        public string RandomCollege() //Finds a random college and returns it
        {
            Random rand = new Random(); //Gets the random class and calls it rand
            int totalColleges = rand.Next(CollegeCityDictionary.Count); //puts the cound of the dictionary and puts it into an integer totalColleges
            string randCollege = CollegeCityDictionary.ElementAt(totalColleges).Key; //Gets a random Key and puts it into the randCollege string

            return randCollege; //Returns the new random college

        }
        
        
    }
}

//Grabs the functions from those places so we can use them
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCapitalApp //Declares the namespace StateCapitalApp
{
    public class StateCapital //Declares the public class where we have the dictionary available publicly
    {
        List<string> StateCapList = new List<string>(); //defines the empty list
        Dictionary<string, string> StateCapDictionary = new Dictionary<string, string>(); //Creates an empty dictionary

        public StateCapital() //Creates the StateCapital method available publicly
        {
            StreamReader inputFile; //opens the text file to be read

            try // try catch to catch any errors that could come up
            {
                inputFile = File.OpenText("statecaps.txt"); //puts the text into the inputFile variable
                while (!inputFile.EndOfStream) //While loop until there's no more lines in the stream
                {
                    string state_cap = inputFile.ReadLine(); //Reads the current line and inputs it into the state_cap variable
                    string[] tempSC = state_cap.Split(','); //splits the state_cap variable by comma and puts it into the tempSC variable
                    StateCapList.Add(state_cap); //Adds the current state_cap line to the list
                    StateCapDictionary.Add(tempSC[0], tempSC[1]); //Adds the individual states and capitals into the dictionary (State = 0, Cap = 1)
                }
                inputFile.Close(); //Closes the text file
            }
            catch (Exception ex) //catches any errors when trying to read and input the text file into the dictionary
            {
                Console.WriteLine(ex.Message); //displays the error found
            }
        }

        public string FindCapital(string state) //Declares a new Method called FindCapital available publicly
        {
            if (StateCapDictionary.TryGetValue(state, out string capital)) //tries to get the value from the dictionary
            {
                return capital; //if it finds it, then returns the capital to the method
            }
            else //if it can't find the state in the dictionary
            {
                return $"Could not find {state} in the dictionary."; //if it doesn't, display that we couldn't find the state in the dictionary
            }
        }
    }
}

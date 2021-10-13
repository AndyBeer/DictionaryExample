using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Dictionaries take in two types - could have used this for the 10.12 lab!  Look @ James' code for that
            //first value = key, 2nd value = value
            //values may repeat as needed, but every key is unique per dictionary

            Dictionary<string, string> homeTowns = new Dictionary<string, string>();
            //we get red curlies if we do not have the "using System.Collections.Generic" at the top.  If that isn't there, the dictionary functionality will not work.

            List<string> students = new List<string>() { "Erin", "Ramone", "James" };

            //we created a list, and now we are going to create our dictionary.  
            //Using the add method, two parameters are taken - key and value.

            homeTowns.Add("Erin", "Texas");
            //using the key as Erin, that means when we search for Erin in the dictionary, we get her corresponding hometown
            homeTowns.Add("Ramone", "Canada");
            homeTowns.Add("James", "South Detroit");

            //printing out our list of students and their indexes
            //*Making a print list method (below)
            PrintList(students);
            
            PrintDictionary(homeTowns);

            // This is showing us how to use the index of one list, to then use that selected index to feed the key into the dictionary, to return the value assoc w that - the hometown in this case.
            string response = Prompt("Which student do you want to learn about?  Select by index.  ");
            int pick = int.Parse(response);  //not validating or limiting, due to time - we would normally want to account for errors here

            string name = students[pick];
            string home = homeTowns[name];

            Console.WriteLine($"{name}'s home town is {home}.");
            


        }
        public static void PrintList(List<string> Names)
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine($"{i}: {Names[i]}");
            }
        }
        public static void PrintDictionary(Dictionary<string, string> dict)
        //"dict" above is just instantiating the name of the dictionary within this method

        {
            foreach (string key in dict.Keys) //dict.Key is a list of all the keys in the dictionary 'dict' - looping through that will allow us to see the values
            {
                Console.WriteLine("Key: " + key);
                string value = dict[key];
                Console.WriteLine("Value: " + value);
                Console.WriteLine();
            }
        }
        public static string Prompt(string display)
        {
            Console.WriteLine(display);
            string input = Console.ReadLine();
            return input;
        }
    }
}

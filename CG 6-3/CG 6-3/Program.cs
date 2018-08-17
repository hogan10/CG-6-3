using System;

namespace CG_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The first sentence of Alice in Wonderland is below. 
             Store this sentence in a string, and then prompt the user for a string to search for within this string. 
              Print whether the search term was found. See if you can make the search case-insensitive, so that searching for “alice” prints true
              */

            //turn the first sentence into a string and store it. 
            //I decided to show the sentence to the user but you could hide it so they have to guess
            //Next I converted the string to lowercase
            string myString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";
            myString = myString.ToLower();
            Console.WriteLine(myString);

            //ask the user to search for a word in the sentence 
            //store their reponse and turn to lowercase
            Console.WriteLine("Please enter a word to see if it appears in the first sentence of Alice in Wonderland: ");
            string userResponse = Console.ReadLine();
            userResponse = userResponse.ToLower();

            //use IndexOf to see if the response appears. Index of is zero based. If a word does not appear it does not have a spot so it is shown as -1
            var search = myString.IndexOf(userResponse);
            //if the word's position is -1, print this message to screen
            if (search == -1)
            {
                Console.WriteLine("This word was not found in the first sentence of Alice in Wonderland. ");

            }
            //if the word's position is not -1, then it is in the sentence. Print this message to screen
            else
            {
                Console.WriteLine("Congrats! This word is found in the first sentence of Alice in Wonderland.");
            }

            Console.ReadLine();

        }
    }
}

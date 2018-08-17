using System;

namespace CG_6_3
{
    class Program
    {
        public static string ALICE { get; private set; }

        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            // ask the user to search a word
            Console.Write("Type a word to search:  ");
            // turn input into string
            string word = Console.ReadLine();

            // set initial string to upper and lower case and 
            alice = word.ToLower() + word.ToUpper() + "Alice";


            if (alice.Contains(alice))
            {
                Console.WriteLine("true");
            }

            else if (alice.Contains(word))
            {
                Console.WriteLine("found");
            }


                Console.ReadLine();
            }
        }
    }

     

    

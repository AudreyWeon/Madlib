using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Madlib
    {
        //declare variables

        static string[] Words = new string[] {
            "Bonnet",
            "Clogs",
            "Water",
            "Hand",
            "Air",
            "Bounded",
            "FineClothes",
            "Jewels"
        };

        static string[] Prompts = new string[] {
            "Noun",
            "Noun (Plural)",
            "Noun",
            "Noun",
            "Noun",
            "Verb",
            "Noun (Plural)",
            "Noun (Plural)",
        };

        static string Story;
        static string GameTitle;

        
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            Console.Title = "Create Your Own Madlilb!";

            //make a header and write out instructions

            Console.WriteLine("~~~~~~");
            Console.WriteLine("Madlib");
            Console.WriteLine("~~~~~~");
        }

        static void GetWords()
        {
            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write("Enter a " + Prompts[i] + ": ");
                Words[i] = Console.ReadLine();
            }

            Console.Clear();
                    
        }

        static void WriteStory()
        {
            GameTitle = "The Frog Prince";

            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            Console.WriteLine(GameTitle);
            Console.Title = GameTitle;

            //write the story

            Story = "One fine evening a young princess put on her {0}, and {1}, and went out to take a walk by herself in a" +
                " wood; and when she \ncame to a cool spring of {2}, that rose in the midst of it, she sat herself " +
                "down to rest a while. Now she had a golden \nball in her {3}, which was her " +
                "favorite plaything; and she was always tossing it up into the {4}, and " +
                "catching it again as \nit fell. After a time she threw it up so high that she missed" +
                " catching it as it fell; and the ball {5} away, and rolled \nalong upon the ground, " +
                "till at last it fell down into the spring. The princess looked into the " +
                "spring after her ball, \nbut it was very deep, so deep that she could not " +
                "see the bottom of it. Then she began to bewail her loss, and said, \n'Alas! If I " +
                "could only get my ball again, I would give all my {6} and {7}, and everything that" +
                " I have in the world.'";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], 
                Words[5], Words[6], Words[7]);

        }
        static void End()
        { 
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();    
        }

    }
}

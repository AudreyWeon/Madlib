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
            "GoldenBall",
            "Air",
            "Bounded",
            "Spring",
            "FineClothes",
            "Jewels",
            "Story"
        };

        static string[] Prompts = new string[]
        {
            "Noun",
            "Noun (Plural)",
            "Noun",
            "Noun",
            "Noun",
            "Verb",
            "Noun",
            "Noun (Plural)",
            "Noun (Plural)",
            "Noun"
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
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];

            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            Console.WriteLine(GameTitle);
            Console.Title = GameTitle;

            //write the story

            Story = "One fine evening a young princess put on her {0}, and {1}, and went out to take a walk by herself in a wood; and when she came to a cool \nspring of {2}, that rose in the midst of it, she sat herself down to rest a while. Now she had a {3} in her hand, which was her \nfavorite plaything; and she was always tossing it up into the {4}, and catching it again as \nit fell. After a time she threw it up so high that she missed catching it as it fell; \nand the {5} {6} away, and rolled along upon the ground, till at last it fell down into the {7}. The princess \nlooked into the {8} after her {9}, but it was very deep, so deep that \nshe could not see the bottom of it. Then she began to bewail her loss, and said, 'Alas! If I \ncould only get my {10} again, I would give all my {11} and {12}, and everything that I have in the world.'";
            Console.WriteLine(Story);
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

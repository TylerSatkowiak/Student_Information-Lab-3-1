using System;
using System.ComponentModel;
namespace Student_Information_Lab_3_1
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Charles", "Tyler", "Jeff", "Ben", "Ari", "Zach", "Kelli" };
            string[] candy = { "Reeses", "Fast Break", "Peeps", "Twizzlers", "Dibella's", "Kimchi", "Cow Tails" };
            string[] titles = { "Accountant", "Line Cook", "Rodeo Clown", "Government Insuring", "Taxidermist", "Painter", "Lifeguard" };
            bool ValidName = true;
            int j = 0;

            while (ValidName)
            {
                Console.WriteLine("Welcome to Sift where the only information we keep is our Team Member's favorite candy and what they used to do.");
                Console.WriteLine("Which user would you like to know more about?");
                Console.WriteLine("[{0}]", string.Join(", ", names));
                string entry = Console.ReadLine();

                if (!int.TryParse(entry, out j) || j > names.Length || j<=0)
                {
                    Console.WriteLine("Please select a valid user.");
                }
                else
                {
                    ValidName = false;
                }
            }

            int i = j - 1;
            Console.WriteLine($"You have selected {names[i]}.", i, names[i]);
            Console.WriteLine($"Would you like to know {names[i]}'s favorite candy or their previous role?");
            string question = Console.ReadLine().ToLower();

            if (question == "candy" || question == "c" || question == "1")
            {
                Console.WriteLine($"{names[i]}'s favorite candy is {candy[i]}.");
            }
            else if(question=="role"|| question =="r"|| question == "2")
            {
                Console.WriteLine($"{names[i]}'s previous role was a(n) {titles[i]}.");
            }
            else
            {
                Console.WriteLine("That input was incorrect, please try again.");
            }

            Console.WriteLine("Would you like to select a different user? ('Y' to keep going, else any other key to quit.)");
            string yn = Console.ReadLine();
            if (yn == "Y" || yn == "y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}

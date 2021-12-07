using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine("");
            string favoriteSubject = Console.ReadLine().ToLower();
            Console.WriteLine("");

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Math? I know how to plus and take away.");
                    break;
                case "english":
                    Console.WriteLine("English? Hey I speak that language!");
                    break;
                case "history":
                    Console.WriteLine("History? That happened a long time ago.");
                    break;
                case "science":
                    Console.WriteLine("Science? We don't believe in that here.");
                    break;
                case "art":
                    Console.WriteLine("Art? How's that working out for you?");
                    break;
                default:
                    Console.WriteLine(favoriteSubject.ToUpperInvariant() + "? I've heard about that but I didn't think it was real.");
                    break;
            }
        }
    }
}

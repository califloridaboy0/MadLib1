using System;

namespace MadLib1
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a verb (hit Enter)");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Enter another verb");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Enter a place");
            string place1 = Console.ReadLine();

            Console.WriteLine("Enter an adverb");
            string adv1 = Console.ReadLine();

            Console.WriteLine("Enter a celebrity's name");
            string celeb1 = Console.ReadLine();

            string NewVerb = Verb.SentBuilder1();

            string NewFrag = Verb.SentBuilder2();

            Console.WriteLine(celeb1+ NewVerb + adv1 + " " + verb1 + NewFrag + place1+". ");
        }
    }
}

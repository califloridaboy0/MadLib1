using System;
namespace MadLib1
{
    public class Verb
    {

        static public string SentBuilder1()
        {
            Console.WriteLine("Enter a number: 1, 2, 3, or 4.");
            int x = Convert.ToInt16(Console.ReadLine());

            switch (x) {
                case 1: return (" will ");
                    break;
                case 2: return (" wants to ");
                    break;
                case 3: return (" will never ");
                    break;
                case 4: return (" is dying to ");
                default: return (" Error ");
            }
        }

        static public string SentBuilder2()
        {
            Console.WriteLine("Enter another number: 1, 2, or 3.");
            int y = Convert.ToInt16(Console.ReadLine());
            switch (y)
            {
                case 1: return (" all the way to ");
                    break;
                case 2: return (" all the way back from ");
                    break;
                case 3: return (" while at ");
                    break;
                default: return("Error");
            }
        }

        public Verb()
        {
            //public string[] NewVerb = new string[3];
            
        }
    }
}

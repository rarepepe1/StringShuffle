using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Buchstaben_vertauschen
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic l = new Logic();
            string[] array = { "Universität", "englischen" };
            foreach (var s in array)
            {
                l.SingleWordOutput(s);
                l.TwoAlgrotihmsOutput(s);
            }

            string[] sentenceArray =
            {
                "Gemäß einer Studie einer englischen Universität ist es nicht wichtig, in welcher Reihenfolge die Buchstaben in einem Wort sind.",
                "Das einzige, was wichtig ist, ist, dass der erste und der letzte Buchstabe an der richtigen Position sind.",
                "The quick brown fox jumps over the lazy dog"
            };

            foreach (var s in sentenceArray)
            {
                l.ShuffleSentence(s);
            }

            Console.ReadKey();
        }
    }
}

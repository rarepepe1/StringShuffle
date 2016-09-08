using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Logic
    {
        //Quelle: http://www.dotnetperls.com/fisher-yates-shuffle
        public string Shuffle(string word)
        {
            string shuffledString = string.Empty;
            char[] chars = word.ToCharArray();
            Random random = new Random();
            int n = chars.Length-1;
            for (int i = 1; i < n; i++)
            {
                int r = i + (int)(random.NextDouble() * (n - i));
                char c = chars[r];
                chars[r] = chars[i];
                chars[i] = c;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                shuffledString += chars[i];
            }
            return shuffledString;
        }

        public string AlternateShuffle(string word)
        {
            string shuffledString = string.Empty;
            char[] chars = word.ToCharArray();
            int n = chars.Length - 3;
            int j = 0;
            for (int i = 1; i < n; i++)
            {
                char temp = word[i];
                chars[i] = chars[n-j];
                chars[n-j] = temp;
                j++;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                shuffledString += chars[i];
            }
            return shuffledString;
        }

        public void ShuffleSentence(string str)
        {
            StringBuilder sb = new StringBuilder("\n--Sentence with 2 algoritms: \n");
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                int n = word.Length-1;
                string newString = word.Trim('.', ',', '!', '?');
                int f = 20 - newString.Length;
                sb.Append(newString);
                Fill(sb, f);
                sb.Append(Shuffle(newString));
                Fill(sb, f);
                sb.Append(AlternateShuffle(newString)+ "\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public void SingleWordOutput(string str)
        {
            StringBuilder sb = new StringBuilder("\n--One Word: \n" + str);
            int f = 20 - str.Length;
            Fill(sb, f);
            string newString = Shuffle(str);
            sb.Append(newString);
            Console.WriteLine(sb.ToString());
        }

        public void TwoAlgrotihmsOutput(string str)
        {
            StringBuilder sb = new StringBuilder("\n--One word, 2 different algorithms: \n" + str);
            int f = 20 - str.Length;
            Fill(sb, f);
            sb.Append(Shuffle(str));
            Fill(sb, f);
            sb.Append(AlternateShuffle(str));
            Console.WriteLine(sb.ToString());
        }

        public void Fill(StringBuilder sb, int x)
        {
            for (int i = 0; i < x; i++)
            {
                sb.Append(" ");
            }
        }

    }
}

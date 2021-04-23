using System;
using System.Linq;

namespace Code_Exam
{
    public class Exam
    {
        public string ParseAndReplace(string input)
        {
            // Splitting string based on any non-aplhabetic character
            string[] words = input.Split(input.Where(ch => !Char.IsLetter(ch)).ToArray());
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 2)
                {
                    var subString = words[i].Substring(1, words[i].Length - 2);
                    int dist = subString.Distinct().Count();
                    result = $"{words[i].ElementAt(0)}{dist}{words[i].ElementAt(words[i].Length - 1)}";
                    input = input.Replace(words[i], result);
                }
                else
                {
                    result = $"{words[i].ElementAt(0)}0{words[i].ElementAt(words[i].Length - 1)}";
                    input = input.Replace(words[i], result);
                }
            }
            return input;
        }
    }
}

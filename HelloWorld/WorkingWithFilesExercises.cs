using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class WorkingWithFilesExercises
    {
        public void run()
        {
            exercise2();
        }

        // Count words
        public void exercise1()
        {
            Console.WriteLine("Exercise 1\n");
            var file = File.ReadAllText(@"C:\Users\HS_1\documents\visual studio 2015\Projects\HelloWorld\HelloWorld\SampleText.txt");

            var wordsCount = 0;
            foreach (var line in file.Split('\n'))
            {
                foreach (var word in line.Split(' '))
                {
                    if (!String.IsNullOrWhiteSpace(word))
                        wordsCount++;
                }
            }
            Console.WriteLine("Word count : " + wordsCount);
        }

        // Longest word
        public void exercise2()
        {
            Console.WriteLine("Exercise 2\n");
            var text = File.ReadAllText(@"C:\Users\HS_1\documents\visual studio 2015\Projects\HelloWorld\HelloWorld\SampleText.txt");
            
            string longestWord = "";
            foreach (var line in text.Split('\n'))
            {
                foreach (var word in line.Split(' '))
                {
                    if (!String.IsNullOrWhiteSpace(word) && longestWord.Length < word.Length)
                        longestWord = word;
                }
            }
            Console.WriteLine("Longest word : " + longestWord);
        }
    }
}

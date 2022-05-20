using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class WorkingWithTextExercises
    {
        public void run()
        {
            exercise5();
        }

        public void exercise1()
        {
            Console.WriteLine("Exercise 1\n");

            Console.Write("Enter numbers separated by hyphen : ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return;

            Console.WriteLine(input);

            var charList = input.Split('-');
            int previousNum = int.MinValue;
            foreach (var item in charList)
            {
                var number = Convert.ToInt32(item);
                if (previousNum == int.MinValue)
                { 
                    previousNum = number;
                    continue;
                }

                if (number - previousNum != -1 && number - previousNum != 1)
                {
                    Console.WriteLine("Non-consecutive");
                    return;
                }

                previousNum = number;
            }
            Console.WriteLine("Consecutive");
        }

        public void exercise2()
        {
            Console.WriteLine("Exercise 2\n");

            Console.Write("Enter numbers separated by hyphen : ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return;

            Console.WriteLine(input);

            var charList = input.Split('-');
            var numList = new List<int>();
            foreach (var item in charList)
            {
                var number = Convert.ToInt32(item);
                if(numList.Contains(number))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
                numList.Add(number);
            }
        }

        public void exercise3()
        {
            Console.WriteLine("Exercise 3\n");

            Console.Write("Enter time in valid format : ");
            var input = Console.ReadLine();

            DateTime dt;
            var dateParseStatus = DateTime.TryParse(input, out dt);

            if(dateParseStatus)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Invalid Time");
        }

        public void exercise4()
        {
            Console.WriteLine("Exercise 4\n");

            Console.Write("Enter words separated by space : ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var wordList = input.Split(' ');
            var builder = new StringBuilder();

            foreach (var word in wordList)
            {
                builder
                    .Append(word.Substring(0,1).ToUpper())
                    .Append(word.Substring(1).ToLower());
            }
            Console.WriteLine(builder);
        }

        public void exercise5()
        {
            Console.WriteLine("Exercise 5\n");

            Console.Write("Enter a word : ");
            var input = Console.ReadLine().ToLower();

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var vowelsCount = 0;
            foreach (var ch in input)
            {
                if (vowels.Contains(ch))
                    vowelsCount++;
            }
            Console.WriteLine("Vowels count : " + vowelsCount);
        }
    }
}

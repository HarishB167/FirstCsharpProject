using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ArraysAndListsExercises
    {
        public void run()
        {
            //exercise1();
            //reverseName();
            exercise5();
        }

        public void exercise1()
        {
            Console.WriteLine("Exercise 1");

            var namesList = new List<string>();

            while (true)
            {
                Console.Write("Enter name : ");
                var input = Console.ReadLine();

                if (input.Length == 0)
                {
                    break;
                }

                namesList.Add(input);
            }

            if (namesList.Count == 0)
            {
                Console.WriteLine("No names available.");
            }
            else if (namesList.Count == 1)
            {
                Console.WriteLine(string.Format("1 name given : {0}", namesList[0]));
            }
            else if (namesList.Count == 2)
            {
                Console.WriteLine(string.Format("2 names given are {0} and {1}", namesList[0], namesList[1]));
            }
            else
            {
                Console.WriteLine(string.Format("Names are {0}, {1} and others", namesList[0], namesList[1]));
            }
        }

        public void reverseName()
        {
            Console.WriteLine("Program Reverse Name");
            Console.Write("Enter name : ");

            var input = Console.ReadLine();

            var charList = new List<char>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                charList.Add(input[i]);
            }

            foreach (var item in charList)
            {
                Console.WriteLine(item);
            }
            var nameReversed = new string(charList.ToArray());
            Console.WriteLine("Reversed name : " + nameReversed);
        }

        public void exercise3()
        {
            Console.WriteLine("Exercise 3\n");
            Console.WriteLine("Please enter atleast 5 unique numbers.");

            var numbersList = new List<int>();

            while(true)
            {
                Console.Write("Enter a number : ");
                var input = Console.ReadLine();
                var number = getNumber(input);
                if (number == int.MinValue || numbersList.Contains(number))
                {
                    Console.WriteLine("Wrong input or number already exists, please retry");
                    continue;
                }
                numbersList.Add(number);
                if (numbersList.Count >= 5)
                {
                    break;
                }
            }
            numbersList.Sort();
            foreach (var num in numbersList)
            {
                Console.WriteLine(num);
            }

        }

        public void exercise4()
        {
            Console.WriteLine("Exercise 4\n");
            var numbersList = new List<int>();

            while(true)
            {
                Console.Write("Enter a number or 'Quit' to exit : ");
                var input = Console.ReadLine();

                if (input.Contains("Quit"))
                    break;
                var number = getNumber(input);
                if (!numbersList.Contains(number))
                    numbersList.Add(number);
            }

            foreach (var num in numbersList)
            {
                Console.WriteLine(num);
            }

        }

        public void exercise5()
        {
            Console.WriteLine("Exercise 5\n");

            var numList = new List<int>();
            while(true)
            {
                Console.Write("Enter numbers list as comma separated values : ");
                var input = Console.ReadLine();

                foreach (var item in input.Split(','))
                {
                    numList.Add(getNumber(item.Trim()));
                }
                if (numList.Count >= 5)
                    break;
                Console.WriteLine("Invalid List, retry.");
                numList.Clear();
            }

            numList.Sort();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }

        public int getNumber(string value)
        {
            try
            {
                var number = int.Parse(value);
                return number;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input : " + value);
                return int.MinValue;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ControlFlowExercises
    {
        public void run()
        {
            //countDivisibleNumbers();
            //repeatedSum();
            //factorial();
            //numberGuessing();
            maxOfNumbers();
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
                return -1;
            }
        }

        public void countDivisibleNumbers()
        {
            Console.WriteLine("Count numbers divisible by 3.");

            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("Result : " + count);
        }

        public void repeatedSum()
        {
            Console.WriteLine("Repeated sum.\n");
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'OK' to exit.");
                var input = Console.ReadLine();
                if (string.Compare(input, "OK") != -1)
                    return;

                var result = getNumber(input);
                if (result != -1)
                    sum += result;
                Console.WriteLine("Sum : " + sum);
            }
        }

        public void factorial()
        {
            Console.WriteLine("Calculating factorial");
            Console.WriteLine("Enter a number : ");
            var input = Console.ReadLine();
            var result = getNumber(input);
            if (result == -1)
                return;
            var factorial = result;
            for (int i = result - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(string.Format("{0}! = {1}", result, factorial));
        }

        public void numberGuessing()
        {
            Console.WriteLine("Number guessing.\n");
            var number = new Random().Next(1,10);
            Console.WriteLine("to guess : " + number);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter possible number : ");
                var input = Console.ReadLine();

                var guessedNumber = getNumber(input);
                if (guessedNumber != -1 && guessedNumber == number)
                {
                    Console.WriteLine("You won");
                    return;
                }
                Console.WriteLine("Retry...");
            }
            Console.WriteLine("You lost");
        }

        public void maxOfNumbers()
        {
            Console.WriteLine("Getting max of numbers.\n");
            Console.Write("Enter numbers seperated by comma : ");
            var input = Console.ReadLine();
            var output = input.Split(',');

            var max = int.MinValue;
            foreach (var item in output)
            {
                var number = getNumber(item);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Maximum number is : " + max);
        }
    }
}

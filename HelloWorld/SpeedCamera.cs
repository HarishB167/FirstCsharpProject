using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class SpeedCamera
    {
        public void run()
        {
            Console.WriteLine("Speed Camera Program.\n");

            Console.WriteLine("Enter speed limit : ");

            string input = Console.ReadLine();
            var speedLimit = getNumber(input);
            if (speedLimit < 0)
                return;
            Console.WriteLine("Speed of car : ");
            input = Console.ReadLine();
            var speed = getNumber(input);
            if (speed <= speedLimit)
                Console.WriteLine("OK");
            else
            {
                var demeritPoints = (speed - speedLimit) / 5;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit Points : " + demeritPoints);
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
                return -1;
            }
        }
    }
}

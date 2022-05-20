using System;
using System.IO;
using HelloWorld.Math;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, RegisteredAirMail = 2, Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // imageOrientCheck();
            // SpeedCamera camera = new SpeedCamera();
            // camera.run();
            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((char)('a' + random.Next(0,26)));
            //}
            //Console.WriteLine();

            //var exerciese = new ControlFlowExercises();
            //exerciese.run();
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //var exercises = new ArraysAndListsExercises();
            //exercises.run();

            //var dateTime = new DateTime(2022, 5, 19);
            //var now = DateTime.Now;
            //var date = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString());

            //var builder = new StringBuilder();
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);
            //builder.Replace('-', '+');
            //builder.Remove(0, 10);
            //builder.Insert(0, new string('-', 10));
            //Console.WriteLine(builder);

            //var textEx = new WorkingWithTextExercises();
            //textEx.run();

            //var path = @"C:\Projects\folder.fold\file.name.ext";

            //Console.WriteLine(Path.GetExtension(path));
            //Console.WriteLine(Path.GetFileName(path));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine(Path.GetDirectoryName(path));

            var flEx = new WorkingWithFilesExercises();
            flEx.run();
        }

        static void runMaxCalc()
        {
            Console.WriteLine("Program to get max of 2 numbers");

            Console.WriteLine("Enter 1st :");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd :");
            string input2 = Console.ReadLine();

            try
            {
                var number1 = int.Parse(input1);
                var number2 = int.Parse(input2);

                if (number1 >= number2)
                    Console.WriteLine("Max is : " + number1);
                else
                    Console.WriteLine("Max is : " + number2);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input : " + input1);
                Console.WriteLine("Wrong input : " + input2);
                return;
            }
        }

        static void imageOrientCheck()
        {
            Console.WriteLine("Program to check image orientation.");

            Console.WriteLine("Enter width :");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter height :");
            string input2 = Console.ReadLine();

            try
            {
                var width = int.Parse(input1);
                var height = int.Parse(input2);

                if (width > height)
                    Console.WriteLine("Image is Landscape");
                else if (width < height)
                    Console.WriteLine("Image is Portrait");
                else
                    Console.WriteLine("Image is Square");
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input : " + input1);
                Console.WriteLine("Wrong input : " + input2);
                return;
            }
        }
    }
}

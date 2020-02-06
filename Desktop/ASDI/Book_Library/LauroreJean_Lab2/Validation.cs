using System;
namespace LauroreJean_Lab2
{
    public class Validation
    {
        public static int ValidateInt(string s) // Send in the prompt
        {
            Console.WriteLine(s); // Display the prompt
            string response = Console.ReadLine();
            int i;
            while (!int.TryParse(response, out i))
            {
                Console.WriteLine("Please enter a valid integer...");
                response = Console.ReadLine();
            }
            return i;
        }
        public static int ValidateMultiInt(string b)
        {
            Console.Write(b);
            string response = Console.ReadLine();
            int i;
            while (!int.TryParse(response, out i))
            {
                Console.WriteLine("Please enter a valid integer...");
                Console.Write(b);
                response = Console.ReadLine();
            }
            return i;
        }
        public static decimal ValidateDecimal(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            decimal d;
            while (!decimal.TryParse(response, out d))
            {
                Console.WriteLine("Please enter a valid decimal number...");
                response = Console.ReadLine();
            }
            return d;
        }
        public static decimal ValidateMultiDecimal(string b)
        {
            Console.Write(b);
            string response = Console.ReadLine();
            decimal d;
            while (!decimal.TryParse(response, out d))
            {
                Console.WriteLine("Please enter a valid decimal...");
                Console.Write(b);
                response = Console.ReadLine();
            }
            return d;
        }
        public static double ValidateDouble(string s)
        {
            Console.WriteLine();
            string response = Console.ReadLine();
            double d;
            while (!double.TryParse(response, out d))
            {
                Console.WriteLine("Please enter a valid number(double)...");
                response = Console.ReadLine();
            }
            return d;
        }
        public static float ValidateFloat(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            float f;
            while (!float.TryParse(response, out f))
            {
                Console.WriteLine("Please enter a valid number(float)...");
                response = Console.ReadLine();
            }
            return f;
        }
        public static string ValidateString(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please do not leave this empty...");
                response = Console.ReadLine();
            }
            return response;
        }
        public static string ValidateMultiString(string b)
        {
            Console.Write(b);
            string response = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please do not leave this empty...");
                Console.Write(b);
                response = Console.ReadLine();
            }
            return response;
        }
    }
}
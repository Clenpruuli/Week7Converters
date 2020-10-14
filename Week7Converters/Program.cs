using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter f for Fahrenheit to Celsius or Enter c for Celsius to Fahrenheit");
            string Userinput = Console.ReadLine();

            if(Userinput == "f")
            {
                FahrenheitToCelsius();

            }else if (Userinput == "c")
            {
                CelsiusToFahrenheit();
            } else 
            {
                Console.WriteLine("Enter f or c!");
            }
           

            

            CelsiusToFahrenheit();
            FahrenheitToCelsius();

        }


        public static void CelsiusToFahrenheit()
        {
            

            double f, c;
            Console.WriteLine("Enter the value of Celsius:");
            c = Convert.ToDouble(Console.ReadLine());
            f = c * 9 / 5 + 32;
            Console.WriteLine(c + "°C in Fahrenheit is: " + f + "°F");



        }
        public static void FahrenheitToCelsius()
        {
            double f, c;
            Console.WriteLine("Enter the value of Fahrenheit:");
            f = Convert.ToDouble(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine(f + "°F in Celsius is: " + c + "°C");
            Console.ReadLine();






        }






    }
}

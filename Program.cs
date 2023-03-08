using System.Diagnostics.Metrics;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintUntilNumber(6);
            //PrintPhrase();
            //PrintFromNumberToOne(10);
            //Division(5,2);
            DivisibleByThreeInRange(1, 34);



            }
        public static void PrintPhrase() 
        {
            int counter = 0;
            Console.WriteLine("How many times?");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            while (counter < number)
            {
                Console.WriteLine("In a hole in the ground there lived a method");
                counter++;
            }
            
        
        }
        public static void PrintUntilNumber(int number)
        {
            int counter = 1;
            while (number >= counter)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
        public static void PrintFromNumberToOne(int number)
        {
            int counter = 1;
            while (number >= counter)
            {
                Console.WriteLine(number);
                number--;
            }
        }
        public static void Division(int numerator, int denominator) 
        {
            //double random = numerator;
            double result = (double)numerator / denominator;
            Console.WriteLine(result);
        }

        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            for (int i = beginning; i < end; i++)
            {
            if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
        }
            }





    }
    }

using System.Diagnostics.Metrics;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            //string srtInput = Console.ReadLine();

           int sumsum = 0;
            while (true)
            {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);// ask 1st for input and convert it
 
                
                if(number == 0)
                {
                    Console.WriteLine("Total sum of numbers: " + sumsum );
                    Console.WriteLine("Total amount of numbers: " + counter);
                    break;
                }


                    sumsum = sumsum + number;
                    counter++;
                
                
                    
              
                

            }
        }
    }
}
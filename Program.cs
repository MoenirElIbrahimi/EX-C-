using System.Diagnostics.Metrics;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int end = 0;
            int counter = 0;
            int sum = 0; 
            int odd = 0;
            int even = 0;
            //string srtInput = Console.ReadLine();


            while (true)
            {
 

            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);// ask 1st for input and convert it

                if (number <= 0) { 
                    sum = end /counter ;
                    Console.WriteLine("Thnx! Bye!" +
                        "\nsum: "+ end +
                        "\nNumbers: " + counter +
                        "\nAverage: " + sum+
                        "\nEven: " + even +
                        "\nOdd: " + odd);
                    break;
                }// calulates the average and prints the sum, number, average, even and odd numbers

                end = end + number; // calulates the sum 
                counter++; // counts up every time the loop loops 
                if (number  % 2 == 0) // filter the even and the odd number
                {
                    even++;
                }
                if (number % 2 == 1)
                {
                    odd++;
                }



            }
        }
    }
}
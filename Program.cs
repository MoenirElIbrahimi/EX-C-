namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {


         //string srtInput = Console.ReadLine();
         

            while (true)
            {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);// ask 1st for input and convert it

                if (number > 0)
                {
                    int sum = number * number;
                    Console.WriteLine(sum);
                }
                if (number < 0)
                {
                    Console.WriteLine("That is negative");
                }
                if(number == 0)
                {
                    break;
                }

            }
        }
    }
}
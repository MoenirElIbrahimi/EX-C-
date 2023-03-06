namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            int numberst = Convert.ToInt32(userInput);// ask 1st for input and convert it

            Console.WriteLine("Give the second number!");
            string userIn = Console.ReadLine();
            int numbernd = Convert.ToInt32(userIn);// ask 2nd for input and convert it


            if (numberst > numbernd) {
                Console.WriteLine("The larger number is "+ numberst);
            }
            if (numberst < numbernd)
            {
                Console.WriteLine("The larger number is " + numbernd);
            }
            if (numberst == numbernd) { 
                Console.WriteLine("They are equal!");
            }


        }
    }
}
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            double first = Convert.ToDouble(userInput); // ask for 1st int ask for input and convert

            Console.WriteLine("Give the second number!");
            string userIn = Console.ReadLine();
            double second = Convert.ToDouble(userIn);// ask for 2nd int ask for input and convert


            double plus = first + second;
            double minus = first - second;
            double keer = first * second;
            double delen = first / second;
            Console.WriteLine(first + " + " + second + " = " + plus + "\n"+
                first + " - " + second + " = " + minus + "\n"+
                first + " * " + second + " = " + keer+"\n" +
                first + " / " + second + " = " + delen); 


        }
    }
}
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            String str = Console.ReadLine(); // ask for string

            Console.WriteLine("Give an integer:");
            string userInput = Console.ReadLine();            
            int intValue = Convert.ToInt32(userInput); // ask for int and convert it

            Console.WriteLine("Give a double:");
            String usInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(usInput); // ask for double and convert it
            
            Console.WriteLine("Give a boolean:");
            string truth = Console.ReadLine();
            bool booleanValue = System.Convert.ToBoolean(truth);
            Console.WriteLine(booleanValue); // ask for boolean and convert it

            Console.WriteLine("Your string: " + str + 
                "\nYour intereger: "  + intValue +
                "\nYour double: "+ doubleValue +
                "\nYour boolean: "+ booleanValue);






        }
    }
}
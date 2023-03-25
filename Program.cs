using HelloWorld;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

List<Book> books = new List<Book>();

while (true)
{
    Console.Write("Name: ");
    string title = Console.ReadLine().Trim();
    if (string.IsNullOrEmpty(title))
    {
        break;
    }

    Console.Write("Pages: ");
    int pages = int.Parse(Console.ReadLine().Trim());

    Console.Write("Publication year: ");
    int publicationYear = int.Parse(Console.ReadLine().Trim());

    Book book = new Book(title, pages, publicationYear);
    books.Add(book);
}

Console.Write("What information will be printed? ");
string option = Console.ReadLine().Trim().ToLower();

switch (option)
{
    case "everything":
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
        break;

    case "title":
        foreach (Book book in books)
        {
            Console.WriteLine(book.title);
        }
        break;

    default:
        break;
}

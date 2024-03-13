using System.Diagnostics.Metrics;
using System.Drawing;
using System.Threading.Channels;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryWithList
{
    internal class Program
    {
        public static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            int choice;
            bool inputCheck = false;
            string BookTitle;
            string authorName;
            bool find = false;

            do
            {
                try
                {
                    Console.WriteLine("Choose options:\n1 Insert book.\n2 Search Book by title.\n3 Search by author.\n4 exit.");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddBook();
                            break;

                        case 2:
                            // search book by title
                            Console.WriteLine("Type a book title:");
                            BookTitle = Console.ReadLine().ToLower();

                            foreach (Book b in books)
                            {
                                if (b.FindBookTitle(BookTitle))
                                {
                                    Console.WriteLine(b.PrintBook());
                                    find = true;
                                }
                            }

                            if (!find) Console.WriteLine("Book not found");

                            break;

                        case 3:
                            //class search author

                            Console.WriteLine("Type an author name:");
                            authorName = Console.ReadLine().ToLower();

                            foreach (Book b in books)
                            {
                                if (b.FindAuthor(authorName))
                                {
                                    Console.WriteLine(b.PrintBook());
                                    find = true;
                                }
                            }

                            if(!find) Console.WriteLine("Book not found");

                            break;

                        case 4:
                            Console.WriteLine("Exit.");
                            inputCheck = true;
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            } while (!inputCheck);
        }
        public static void AddBook()
        {
            bool inputCheck = false;
            do
            {

                try
                {

                    Console.WriteLine("Title:");
                    string Title = Console.ReadLine();

                    Console.WriteLine("Author:");
                    string Author = Console.ReadLine();

                    Console.WriteLine("Publisher:");
                    string Publisher = Console.ReadLine();

                    Console.WriteLine("Year:");
                    int Year = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Rack:");
                    int Rack = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Floor:");
                    int Floor = Convert.ToInt32(Console.ReadLine());

                
                    if (RegisterData()) books.Add(new Book(Title, Author, Publisher, Year, Rack, Floor));

                        inputCheck = true;

                }
                catch (Exception e) {

                    Console.WriteLine("Please insert correct data of all filed!\n" + e.Message);
                }
            } while (!inputCheck);

        }

        static public bool RegisterData()
        {
            bool ConfirmChoice = false;

            Console.WriteLine("Do you want to save the data? (Y/N)");
            ConfirmChoice = Console.ReadLine().ToLower() == "y" ? true : false;

            if (ConfirmChoice)
            {
                Console.WriteLine("Book registered!");
            }
            else
            {
                Console.WriteLine("Book not registered.\n");
            }

            return ConfirmChoice;
        }
    }
}

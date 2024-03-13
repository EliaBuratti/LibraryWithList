using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWithList
{
    internal class Book
    {
        private Hashtable BK = new Hashtable();
        public Book(string title, string author, string publisher, int year, int rack, int floor)
        {
            
            BK.Add("Title", title);
            BK.Add("Author", author);
            BK.Add("Publisher", publisher);
            BK.Add("Year", year);
            BK.Add("Rack", rack);
            BK.Add("Floor", floor);
        }

        public string PrintBook()
        {
            return "\nTitle:" + BK["Title"] + "\nAuthor:" + BK["Author"] + "\nPublisher:" + BK["Publisher"] + "\nYear:" + BK["Year"] + "\nRack:" + BK["Rack"] + BK["Floor"] + "\n";
        }

        public bool FindBookTitle(string BookTitle)
        { 
            return BK["Title"].ToString().Contains(BookTitle);
        }

        public bool FindAuthor(string BookAuthor)
        {
            return BK["Author"].ToString().Contains(BookAuthor);
        }
    }
}

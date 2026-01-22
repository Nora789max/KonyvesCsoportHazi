using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvesCsoport
{
    internal class Book
    {
        public  string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public Book() { }

        public Book(string iSBN, string title, string author, int year, bool isAvailable)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }

        public override string? ToString()
        {
            return ($"ISBN: {ISBN} \t {Title} - {Author} ({Year}) - {(IsAvailable? "Available": "Non Available")} ");
        }
    }
}

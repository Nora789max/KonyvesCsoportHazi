using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvesCsoport.Model
{
    public class Library
    {

        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library() {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void SaveToFile(string filename)
        {
            try
            {
                List<string> LinesToSave = new List<string>();
                foreach (var book in Books)
                {

                    string sor = $"{book.ISBN};{book.Author};{book.Title};{book.Year};{book.IsAvailable}";
                    LinesToSave.Add(sor);
                }
                File.WriteAllLines("DatabaseBooks.txt", LinesToSave, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba!");
            }
        }
        public void AddBook (Book book)
        {
            Book newBook = new Book();
            Console.WriteLine("<--- Könyv hozzáadása--->");
            Console.WriteLine("Az ISBN kód: ");
            newBook.ISBN = Console.ReadLine();
            Console.WriteLine("A könyv címe: ");
            newBook.Title =Console.ReadLine();
            Console.WriteLine("A könyv szerzője: ");
            newBook.Author = Console.ReadLine();
            Console.WriteLine("A könyv kiadási éve: ");
            newBook.Year = int.Parse(Console.ReadLine());
            newBook.IsAvailable = true;

            Books.Add(newBook);
            this.SaveToFile("DatabaseBooks.txt");
            Console.WriteLine("Hozzáadva!");
        }

        public void RemoveBook (string isbn)
        {
            Console.WriteLine("<--- Könyv törlése--->");
            Console.WriteLine("Kérem a keresett ISBN kódot: ");
            
            Book bookToDelete = Books.FirstOrDefault(b => b.ISBN == isbn);

                if (bookToDelete != null)
                {
                    Books.Remove(bookToDelete);
                    SaveToFile("DatabaseBooks.txt");
                    Console.WriteLine("Törölve");
                }
        }

        public void FindBook(string isbn)
        {
            bool found = false;

            foreach (Book book in Books)
            {
                if (book.ISBN == isbn)
                {
                    Console.WriteLine($"ISBN: {book.ISBN} \t {book.Title} - {book.Author} ({book.Year}) - {(book.IsAvailable ? "Available" : "Non Available")}");

                    found = true; 
                    break;
                }
                  
            }
            if (!found)
            {
                Console.WriteLine("Nincs ilyen!");
            }
        }

        public void ListAvailableBooks()
        {
            foreach (var book in Books)
            {
                if (book.IsAvailable == true)
                {
                    Console.WriteLine($"ISBN: {book.ISBN}  | Cím: {book.Title} | Szerző: {book.Author} | Kiadás éve: {book.Year}");
                }

            }

        }
    }
}

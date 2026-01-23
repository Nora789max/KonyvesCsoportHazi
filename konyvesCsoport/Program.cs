using konyvesCsoport.Model;
using System;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static Library Konyvtar = new Library();
        static void Admin()
        {
            Console.WriteLine("<--- Könyvtári Adatbázis --->");
            Console.WriteLine("Admin, mit szeretnél csinálni?  Hozzáadni könyvet [1] vagy eltávolítani [2] ?");
            int toDo = Convert.ToInt32(Console.ReadLine());
            switch (toDo)
            {
                case 1:
                    Konyvtar.AddBook(null);
                    break;
                case 2:
                    Console.Write("Add meg a törölni kívánt ISBN-t: ");
                    string isbn = Console.ReadLine();
                    Konyvtar.RemoveBook(isbn);
                    break;
            }

        }
        static void User()
        {
            Console.WriteLine("<--- Könyvtári Adatbázis --->");
            Console.WriteLine("Tag: ");
            Console.WriteLine("Könyv keresése [1] vagy az elérhető könyvek listája [2]: ");


        }
        static void Main(string[] args)
        {
            Console.WriteLine("<--- Könyvtári Adatbázis --->");
            Console.WriteLine("Admin [1] vagy Tag[2]?");
            int title = Convert.ToInt32(Console.ReadLine());
            switch (title)
            {
                case 1:
                    Admin();
                    break;
                case 2:
                    User();
                    break;
            }
        }
    }
}


//admin hozzáad, töröl isbn alapján

//tag kölcsönöz, visszahoz


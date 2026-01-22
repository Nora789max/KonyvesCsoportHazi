using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvesCsoport.Model
{
    public class Member
    {
        public Member()
        {
        }

        public int MemberID { get; set; }
        public string Name { get; set; }
        public List <Book> BorrowedBooks { get; set; }

        public Member(int memberID, string name, List<Book> borrowedBooks)
        {
            MemberID = memberID;
            Name = name;
            BorrowedBooks = borrowedBooks;
        }

        public override string ToString()
        {
            return ($"{MemberID} - {Name} \n {BorrowedBooks}");
        }
    }
}

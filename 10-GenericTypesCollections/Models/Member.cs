using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericTypesCollections.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book) 
        {
            if (BorrowedBooks.Count<=3)
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Kitab goturuldu: {book.Title}");
            }
            else
            {
                Console.WriteLine("Maksimum 3 kitab goture bilersiniz!");
            }
        }

        public void ReturnBook(int bookId)
        {
            Book findBook = null;
            foreach (Book b in BorrowedBooks)
            {
                if (b.Id == bookId)
                {
                    findBook = b;
                    break;
                }
            }


            if (findBook != null)
            {
                BorrowedBooks.Remove(findBook);
                Console.WriteLine($"Kitab qaytarildi: {findBook.Title}");
            }
        }

        public void DisplayBorrowedBooks()
        {
            
            if (BorrowedBooks.Count==0)
                {
                    Console.WriteLine("Borc kitab yoxdur");
                }



            foreach (Book bb in BorrowedBooks)
            {
           
                Console.WriteLine($"Borc kitab: {bb.Title}");
            }
        }

    }
}

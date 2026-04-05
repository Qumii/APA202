using _10_GenericTypesCollections.Models;

namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ag Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qiriq Budaq", "Elcin", 1998, 350);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Library<Book> library = new Library<Book>("Milli Kitabxana");
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);
            Console.WriteLine("");
            Console.WriteLine($"Kitab sayi: {library.Count()}");

            Console.WriteLine("");
            foreach (Book item in library.GetAll())
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("");

            List<Member> members = new List<Member>();

            Member member1 = new Member(1, "Ali Memmedov", "ali@mail.com");
            Member member2 = new Member(2, "Leyla Hesenova", "leyla@mail.com");
            Member member3 = new Member(3, "Vuqar Aliyev", "vuqar@mail.com");

            members.Add(member1);
            members.Add(member2);
            members.Add(member3);


            member1.BorrowBook(book1);
            member1.BorrowBook(book2);
            Console.WriteLine("");
            member1.DisplayBorrowedBooks();
            Console.WriteLine("");
            member1.ReturnBook(1);
            member1.DisplayBorrowedBooks();
            Console.WriteLine("");
            member1.BorrowBook(book3);
            member1.BorrowBook(book4);
            member1.BorrowBook(book5);
            member1.BorrowBook(book1);



            BookManager bookManager = new BookManager();
            bookManager.AddBook(book1);
            bookManager.AddBook(book2);
            bookManager.AddBook(book3);
            bookManager.AddBook(book4);
            bookManager.AddBook(book5);

            //var orwellsBooks = bookManager.GetBooksByAuthor("George Orwell"); 
            //foreach (Book o in orwellsBooks)
            //{
            //    Console.WriteLine($"George Orwell-in kitablari: {o.Title}");
            //}

            //var cingizsBooks = bookManager.GetBooksByAuthor("Cingiz Aytmatov"); 
            //foreach (Book c in cingizsBooks)
            //{
            //    Console.WriteLine($"Cingiz Aytmatov-un kitablari: {c.Title}");
            //}

            //var londonsBooks = bookManager.GetBooksByAuthor("Jack London"); 
            //foreach (Book l in londonsBooks)
            //{
            //    Console.WriteLine($"Jack London-un kitablari: {l.Title}");
            //}

            //var noneBooks = bookManager.GetBooksByAuthor("Tolstoy");
            //foreach (var n in noneBooks)
            //{
            //    Console.WriteLine($"Tapilan kitab sayi: {noneBooks.Count}");
            //}

            bookManager.AddToWaitingQueue("Nigar");
            bookManager.AddToWaitingQueue("Resad");
            bookManager.AddToWaitingQueue("Sebine");
            Console.WriteLine($"Novbede nece nefer var: {bookManager.WaitingQueue.Count}");
            bookManager.ServeNextInQueue();

            Console.WriteLine("");
            string served = bookManager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served}");

            Console.WriteLine("");
            Console.WriteLine($"Novbede nece nefer qalib: {bookManager.WaitingQueue.Count}");

            Console.WriteLine("");
            bookManager.ReturnBook(book1);
            bookManager.ReturnBook(book2);
            bookManager.ReturnBook(book3);

            Console.WriteLine($"Stack-deki kitab sayi: {bookManager.RecentlyReturned.Count}");

            Console.WriteLine("");
            Book last = bookManager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab: {last.Title}");
            Console.WriteLine("");

            bookManager.RecentlyReturned.Pop();
            Console.WriteLine($"Indi stack-de olan kitab sayi: {bookManager.RecentlyReturned.Count}");
            Console.WriteLine($"Son qaytarilan kitab: {bookManager.GetLastReturnedBook().Title}");

            Console.WriteLine("");
            Book search = bookManager.SearchByTitle("1984");
            if (search != null)
            {
                Console.WriteLine($"Axtaris neticesi: {search.Title}");
            }


            Console.WriteLine("");
            Book noneBook = bookManager.SearchByTitle("Heidi");
            if (noneBook == null) 
            {
                Console.WriteLine("Kitab tapilmadi:(");
            }


            Console.WriteLine("");
            Console.WriteLine($"Umumi kitab sayi: {bookManager.Books.Count}");
            Console.WriteLine("");
            Console.WriteLine($"Umumi uzv sayi: {members.Count}");
            Console.WriteLine("");
            Console.WriteLine($"Novbede nefer sayi: {bookManager.WaitingQueue.Count}");
            Console.WriteLine("");
            Console.WriteLine($"Stack-de kitab sayi: {bookManager.RecentlyReturned.Count}");

            Console.WriteLine("");
            int minYear = int.MaxValue;
            foreach (Book min in bookManager.Books)
            {
                if (min.Year < minYear)
                {
                    minYear = min.Year;
                }
            }
            Console.WriteLine($"En kohne kitabin ili: {minYear}");


            Console.WriteLine("");

            int maxYear = int.MinValue;

            foreach (Book max in bookManager.Books)
            {
                if (max.Year > maxYear)
                {
                    maxYear = max.Year;
                }
            }
            Console.WriteLine($"En yeni kitabin ili: {maxYear}");








        }
    }
}


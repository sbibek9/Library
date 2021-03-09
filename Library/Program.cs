using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        
         
        static void Main(string[] args)
        {
            Console.WriteLine("Library Mangament Menu");
            // 1. Add books
            // 2. Search Books
            // 3. View Issued Books
            // 4. Issue Books
            // 5. Return Books
            
            menu();


        }

        static void menu()
        {
            Console.Write("1. Add books \n2. Search Books \n3. View All Books \n4. Issue Book \n5. Return Book\nPress any other key to exit.\n");
            List<Book> books = new List<Book>();
            while (true)
            {
                string option = Console.ReadLine();
               
                try
                {
                    switch (Int32.Parse(option))
                    {
                        case 1:
                            var val = add();
                            Console.WriteLine(val.bName);
                            books.Add(val);
                            break;
                        case 2:
                            Console.WriteLine("Enter the name of the book to be searched.");
                            string bookname = Console.ReadLine();
                            search(books,bookname);
                            break;
                        case 3:
                            if (books.Count == 0)
                            {
                                Console.WriteLine("Nothing to display");
                                break;
                            }
                            Console.WriteLine("BookId\t| Book Name\t\t\t| Author\t\t| Publisher \t| Issued");
                            view(books);
                            break;
                        case 4:
                            Console.WriteLine("Enter the name of the book to be issued?");
                            string bname = Console.ReadLine();
                            var item = issue(books, bname);
                            foreach (Book value in books)
                            {
                                if (value.bName == item.bName)
                                {
                                    value.issued = true;
                                    break;
                                }
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter the name of the book to be returned");
                            string name = Console.ReadLine();
                            var retunedItem = returnBooks(books,name);
                            foreach (Book value in books)
                            {
                                if (value.bName == retunedItem.bName && value.issued != false)
                                {
                                    value.issued = false;
                                    break;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                catch (Exception e)
                {

                    Environment.Exit(1);
                }
                
            }
        }
        static Book add()
        {
            Book item= new Book(1001,"Introduction to C#","Book Author","Me");
            Console.WriteLine("Adding something");
            return item;
        }
        static void search(List<Book> books,string bName)
        {
            int flag = 0;
            foreach (Book item in books)
            {
                if (item.bName == bName)
                {
                    Console.WriteLine("Found");
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("searching something");
        }
        static void view(List<Book> Book)
        {
            foreach (Book item in Book)
            {
                Console.WriteLine(item.bid +"\t\t"+item.bName +"\t\t" + item.bAuthor + "\t\t" + item.bPublisher + "\t" + item.issued);
            }
        }
        static Book issue(List<Book> books,string bname)
        {
            Console.WriteLine("Issuing something");
            foreach (Book item in books)
            {
                if (item.bName == bname && item.issued!= true)
                {
                    Console.WriteLine("Book issued Successfully");
                    return item;
                }
            }
            return null;
        }
        static Book returnBooks(List<Book> books,string bName)
        {
            Console.WriteLine("returning something");
            foreach (Book book in books)
            {
                if (book.bName == bName && book.issued != false)
                {
                    return book;
                }
            }
            return null;
        }
    }
}

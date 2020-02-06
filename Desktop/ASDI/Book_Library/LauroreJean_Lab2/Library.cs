using System;
using System.Collections.Generic;

namespace LauroreJean_Lab2
{
    public class Library
    {
        private Menu _myMenu;
        private Dictionary<int, Book> _myBook;


        public Library()
        {
            _myMenu = new Menu("Create Book", "Check Out a Book", "Return a Book", "Display Books", "Remove All Books", "Exit");
            _myMenu.Title = "Library Book";
            _myMenu.Display();

            _myBook = new Dictionary<int, Book>();
            Selection();
        }

        private void Selection()
        {
            //Validating user choice or selection
            int choice = Validation.ValidateInt("\nMake a selection:");
            switch (choice)
            {
                case 1:
                    CreateBook();
                    break;

                case 2:
                    CheckOutBook();
                    break;

                case 3:
                    ReturnBook();
                    break;

                case 4:
                    DisplayBooks();
                    break;

                case 5:
                    RemoveAllBooks();
                    break;

                case 6:
                    Exit();
                    break;

                default:
                    break;
            }
        }

        private void CreateBook()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Creating Book:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;

            Book myBook = new Book();
            
            ////Update book object
            myBook.isbn = Validation.ValidateInt("\nPlease enter your 5 ISBN number: ");
            //Looping

            if (_myBook.ContainsKey(myBook.isbn))
            {
                while (_myBook.ContainsKey(myBook.isbn))
                {
                    Console.WriteLine($"{myBook.isbn} already existed");
                    myBook.isbn = Validation.ValidateInt("\nPlease enter your 5 ISBN number: ");
                }
            }
            else
            {
                myBook.title = Validation.ValidateString("\nPlease type your book name: ");
                //Adding to dictionary
                _myBook.Add(myBook.isbn, myBook);
                myBook.isAvailability = true;
                Console.WriteLine($"\nNew book added! {myBook.isbn} {myBook.title}");
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void CheckOutBook()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Check Out Book:");
            Console.WriteLine("===============");
            Console.WriteLine("===============");
            Console.ForegroundColor = ConsoleColor.Gray;

            Book myBook = new Book();

            myBook.isbn = Validation.ValidateInt("\nEnter your ISBN # of the desired book to be checked out from the library: ");

            if (_myBook.ContainsKey(myBook.isbn) || myBook.isAvailability)
            {
                Console.WriteLine($"Your {myBook.isbn} ISBN # is available for check out!.");
                _myBook.Remove(myBook.isbn, out myBook);
            }
            else
            {
                Console.WriteLine("Sorry, The book has already been checked out or not available!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void ReturnBook()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Return Book:");
            Console.WriteLine("============");
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Gray;
            Book myBook = new Book();


            myBook.isbn = Validation.ValidateInt("\nEnter your ISBN number of the desired book to be returned to the library: ");
            //myBook.title = Validation.ValidateString("\nPlease type your book name: ");

            if (_myBook.ContainsKey(myBook.isbn) || myBook.isAvailability)
            {
                //myBook.isAvailability = true;
                Console.WriteLine($"Your {myBook.isbn} ISBN # has already been returned or currently available.");
                //Console.WriteLine($"\nhas {myBook.title}been just returned");
            }
            else 
            {
                myBook.title = Validation.ValidateString("\nPlease type your book name: ");
                //Adding to dictionary
                _myBook.Add(myBook.isbn, myBook);
                myBook.isAvailability = true;
                Console.WriteLine($"\nBook return! {myBook.isbn} {myBook.title}");
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void DisplayBooks()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display Book:");
            Console.WriteLine("=============");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"{"ISBN #",-10} {"Title",-15} {"Avalaibility",-15}");
            foreach (KeyValuePair<int, Book> kvp in _myBook)
            {
                Console.WriteLine($"{kvp.Value.isbn,-10} {kvp.Value.title,-15} {kvp.Value.isAvailability,-15}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void RemoveAllBooks()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove All Book:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Asking for user confidence
            string pick = Validation.ValidateString("\nAre you sure: Press Y for yes || Press N for no.");
            if (pick == "y")
            {
                //Clear the whole book library
                _myBook.Clear();
                Console.WriteLine("\nAll books has bee remove from the library.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            else
            {
                //Clear nothing and return to the main menu
                Console.WriteLine("\nReturning back to Main Menu");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
        }

        private void Exit()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Exit:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nThanks for using my book library. Farewell!");
        }
    }
}

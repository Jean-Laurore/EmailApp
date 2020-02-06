using System;
using System.Collections.Generic;
using System.Linq;
namespace LauroreJean_Lab2
{
    class Menu
    {
        public string Title { get; set; } // This is a property
        private List<string> _items;
        public Menu()
        {
            Title = "Application";
            _items = new List<string>();
        }
        public Menu(params string[] items)
        {
            Title = "Application";
            _items = items.ToList();
        }
        public void AddMenuItem(string item)
        {
            _items.Add(item); // Adds an item to the List.
        }
        public void Display()
        {
            Console.Clear(); // Clean up the screen! Or not...
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=============================");
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_items[i]}");
            }
        }
    }
}
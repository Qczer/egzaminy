using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    class Film
    {
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public int GetBorrowCount()
        {
            return borrowCount;
        }

        public void IncrementBorrowCount()
        {
            borrowCount++;
        }

        protected string title = "";
        protected int borrowCount = 0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            Console.WriteLine($"(Default) Title: {film.GetTitle()}, Borrow Count: {film.GetBorrowCount()}");

            film.SetTitle("Batman");
            Console.WriteLine($"Title Set: {film.GetTitle()}");

            Console.WriteLine($"Borrow Count (Before): {film.GetBorrowCount()}");
            film.IncrementBorrowCount();
            Console.WriteLine($"Borrow Count (After): {film.GetBorrowCount()}");
        }
    }
}

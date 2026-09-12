using System;

// assignment 5
namespace Assignment04
{
    // Helper class for Access Modifiers questions
    public class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           // #region Question 1
            // 1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).
           // double[] prices1 = { 25.5, 40.0, 33.75 };
           // Console.WriteLine(prices1[1]);
           // #endregion

           // #region Question 2
            // 2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
           // int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
           // Console.WriteLine(shelfCopies[1, 0]);
           // #endregion

           // #region Question 3
            // 3-Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main.
            // PrintWelcomeMessage();
           // #endregion

           // #region Question 4
            // 4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            // PrintBookTitle("Clean Code");
           // #endregion

           // #region Question 5
            // 5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward.
            // int pages = 400;
            // AddBonusPages(pages);
            // Console.WriteLine(pages);
           // #endregion

           // #region Question 6
            // 6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 };
            // double[] prices = { 25.5, 40.0 };
            // ApplyDiscount(prices);
            // Console.WriteLine(prices[0]);
           // #endregion

           // #region Question 7
            // 7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            // int pages = 400;
            // AddBonusPagesByRef(ref pages);
            // Console.WriteLine(pages);
           // #endregion

          // #region Question 8
            // 8-Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.
         //   double[] prices = { 25.5, 40.0 };
         //   ReplaceArray(ref prices);
         //   Console.WriteLine(prices.Length);
          // #endregion

            // ==========================================
            // Assignment 5 Regions
            // ==========================================

            // #region Function Parameter Passing - Question 1
            // if (TryGetPrice("Clean Code", out double bookPrice))
            // {
            //     Console.WriteLine($"Price: {bookPrice}");
            // }
            // else
            // {
            //     Console.WriteLine("Book not found!");
            // }
            // #endregion

            #region Function Parameter Passing - Question 2
            // 2-Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.
            PrintBookInfo("Clean Code");
            PrintBookInfo("Design Patterns", 450);
            #endregion

            // #region Function Parameter Passing - Question 3
            // PrintBookInfo(pages: 500, title: "Refactoring");
            // #endregion

            // #region Function Parameter Passing - Question 4
            // PrintAllTitles("Clean Code", "Design Patterns", "C# in Depth");
            // #endregion

            // #region Access Modifiers - Question 1
            // Book myBook1 = new Book();
            // #endregion

            // #region Access Modifiers - Question 2
            // Book myBook2 = new Book();
            // Console.WriteLine(myBook2.copiesInStock);
            // #endregion

            // #region Access Modifiers - Question 3
            // Book myBook3 = new Book();
            // myBook3.Title = "Clean Architecture";
            // Console.WriteLine(myBook3.Title);
            // #endregion
        }

        // static bool TryGetPrice(string title, out double price)
        // {
        //     price = title == "Clean Code" ? 25.5 : 0;
        //     return title == "Clean Code";
        // }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        // static void PrintAllTitles(params string[] titles)
        // {
        //     foreach (var title in titles)
        //     {
        //         Console.WriteLine(title);
        //     }
        // }
    }
}
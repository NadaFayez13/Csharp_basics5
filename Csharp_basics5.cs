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

            
            // Assignment 5 
            

            // #region Function Parameter Passing - Question 1
            // #endregion

            // #region Function Parameter Passing - Question 2
            // #endregion

            // #region Function Parameter Passing - Question 3
            // #endregion

            // #region Function Parameter Passing - Question 4
            // #endregion

            #region Access Modifiers - Question 1
            // 1-Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            Book myBook1 = new Book();
            // Console.WriteLine(myBook1.password); // Compilation Error!

            /*
             * What happens: Compilation error occurs ('Book.password' is inaccessible due to its protection level).
             * Why: The 'private' access modifier restricts member accessibility strictly to within the same class body where it is declared.
             */
            #endregion

            // #region Access Modifiers - Question 2
            // #endregion

            // #region Access Modifiers - Question 3
            // #endregion
        }
    }
}
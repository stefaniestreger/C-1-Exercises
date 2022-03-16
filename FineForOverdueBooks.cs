using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
   public static void Main()
   {
    int books;
    int days;
    string input;
    Write("Enter the number of books checked out: ");
    input = ReadLine();
    books = Convert.ToInt32(input);
    Write("Enter the number of days overdue: ");
    input = ReadLine();
    days = Convert.ToInt32(input);
    DisplayFine(books, days);
   }

   public static void DisplayFine(int books, int days)
   {
    double remainderDays = 0;
    double fine = 0;
    if (days <= 7) {
      fine = (books * .10) * days;
    }
    if (days > 7) {
      remainderDays = days - 7;
      fine = ((books * .20) * remainderDays) + ((books * .10) * 7);
    }
    WriteLine("The fine for {0} book(s) for {1} day(s) is {2}", books, days, fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}

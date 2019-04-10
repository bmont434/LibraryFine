using System;
using static System.Console;
public class FineForOverdueBooks
{
   public static void Main()
   {
    string inpbooks = ReadLine();
   int convbooks = Convert.ToInt32(inpbooks);
   string inpdays = ReadLine();
   int convdays = Convert.ToInt32(inpdays);
    DisplayFine(convbooks, convdays);
   
   }
   public static void DisplayFine(int books, int days)
   {
   double fine = 0;
   double overdue = 7 * .10;
   if (days <= 7) {
        fine = (.10 * days) * books; 
    }
    if (days > 7) {
        fine = (overdue * books) + (.20 * (days - 7)) * books;
    }
       Write("The fine for {0} book(s) for {1} day(s) is {2}", books, days, fine.ToString("C"));
   }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Auction
{
   static void Main() {

     int minBid = 10;
     Write("Enter bid amount: ");
     string amount = Console.ReadLine();
     AcceptBid(int.Parse(amount), minBid);
     AcceptBid(double.Parse(amount), minBid);
     AcceptBid(amount, minBid);
    }
   
   public static void AcceptBid(int bid, int min)
   {
      if (bid >= min) {
       Write("Bid accepted");
     }
     else {
       Write("Bid not high enough");
     }
   }
   
   public static void AcceptBid(double bid, int min)
   {
     double newBid = Convert.ToDouble(bid);
     if (newBid >= min) {
       Write("Bid accepted");
     }
     else {
       Write("Bid not high enough");
     }
   }

   public static void AcceptBid(string bid, int min)
   { 
     if (bid.Contains('$')) {
       string[] strArray = bid.Split('$');
       if (int.TryParse(strArray[1], out int num)) {
         if (num >= min) {
           Write("Bid accepted");
         }
         else {
           Write("Bid not high enough");
         }
        }
       }  
        
      if (bid.Contains("dollars")) {
        int i = bid.IndexOf("dollars");
        string dollar = bid.Substring(i);
        string amount = bid.Substring(0, bid.Length - dollar.Length);
        if (int.TryParse(amount, out int result)) {
          if (result >= min) {
            Write("Bid accepted.");
            }
            else {
              Write("Bid not high enough");
              }
            }
          }
          
        else {
           Write("Bid was not in correct format.");
            }
          }
}

using System;
using static System.Console;
class MultiplicationTable
{
   static void Main()
   {
       double userNumber;
       string input;
       double prodStart;
       const double PRODEND = 10;
       double prodTotal;
       Write("Enter an integer: ");
       input = ReadLine();
       userNumber = Convert.ToDouble(input);
       Write("Integer Products");
       WriteLine();
       WriteLine("--------------");
       for(prodStart = 1; prodStart <= PRODEND; ++prodStart) {
        prodTotal = prodStart * userNumber;
        WriteLine("{0} x {1} = {2}", prodStart, userNumber, prodTotal);
       };
   }
}

using System;
using static System.Console;
class WebAddress
{
   static void Main()
   {
        string input;
        string businessName;
        Write("Enter a business name: ");
        input = ReadLine();
        businessName = input;
        string newName = businessName.Replace(" ", "");
        WriteLine("Suggested business name is www.{0}.com", newName);
   }
}

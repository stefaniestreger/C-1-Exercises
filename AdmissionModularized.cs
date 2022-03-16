using System;
using static System.Console;
class AdmissionModularized
{
   static void Main()
   {
      double gpa;
      int testScore;
      string inputString;
      WriteLine("Enter grade point average ");
      inputString = ReadLine();
      gpa = Convert.ToDouble(inputString);
      WriteLine("Enter test score ");
      inputString = ReadLine();
      testScore = Convert.ToInt32(inputString);
      WriteLine(AcceptOrReject(gpa, testScore));
   }
    public static string AcceptOrReject(double gpa, int testScore)
   {
      const double MINGPA = 3.0;
      const int ADMIN1 = 60, ADMIN2 = 80;
      string accept = "Accept";
      string reject = "Reject";
      if(gpa >= MINGPA && testScore >= ADMIN1) 
          return accept;
      if(gpa >= MINGPA && testScore >= ADMIN2)
          return accept;
      if(gpa < MINGPA && testScore >= ADMIN2)
          return accept;
      else
          return reject;
      }
   }

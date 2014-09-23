using System;

class ForEach
{
   static void Main()
   {
      string s = "0123456789";
      foreach (char number in s)
      {
         if (number % 2 == 0) {
            Console.WriteLine (number);
         }
      }

   }
}

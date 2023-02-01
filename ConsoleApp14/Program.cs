using System;
namespace Uppgift_2._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Säg en anställds lön");
            string strNr1 = Console.ReadLine();
            int intNr1 = Convert.ToInt32(strNr1);
            
            Console.WriteLine("Säg en till anställds lön.");
            string strNr2 = Console.ReadLine();
            int intNr2 = Convert.ToInt32(strNr2);
          
            Console.WriteLine("Säg en till anställds lön.");
            string strNr3 = Console.ReadLine();
            int intNr3 = Convert.ToInt32(strNr3);
            
            int mdlvrd = (intNr1 + intNr2 + intNr3) / 3;

            Console.WriteLine("Medelvärdet på lönerna är " + mdlvrd);

        }
    }
}
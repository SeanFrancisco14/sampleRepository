using System;

namespace SampleConsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = {"John", "Raye", "Mike", "Pam", "Carlo", "Imogen", "Caleb"};
            string[] Places = { "Manila", "Cebu", "Davao", "Pasay" };

            Random rndNames = new Random();
            int indexNames = rndNames.Next(Names.Length);
            Random rndPlaces = new Random();
            int indexPlaces = rndPlaces.Next(Places.Length);

            
            Console.WriteLine($"{Names[indexNames]} is at {Places[indexPlaces]}");
            Console.ReadLine();
        }
    }
}

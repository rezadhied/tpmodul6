using System;

namespace tpmodul6_1302213016
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo v = new SayaTubeVideo("Tutorial Design By Contract - Reza Adhie Dharmawan");
            v.PrintVideoDetails();

            Console.WriteLine("\nIncreasing Play Count:");
            v.IncreasePlayCount(145);
            v.PrintVideoDetails();
        }
    }
}

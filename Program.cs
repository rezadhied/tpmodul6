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

            SayaTubeVideo video1 = new SayaTubeVideo(null);

            SayaTubeVideo video2 = new SayaTubeVideo("Video tes playcount");
            for (int i = 0; i < 100; i++)
            {
                video2.IncreasePlayCount(9999999);
            }
            video2.PrintVideoDetails();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213016
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 100, 
                "Judul video harus memiliki panjang maksimal 100 karakter dan tidak berupa null");
         
            this.id = new Random().Next(100, 999);
            try
            {
                this.title = checked(title);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000);

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }

    


}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD6_1302210081
{
    class SayaTubeVideo
    {
        private int id;

        private String title;

        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;

            var a = this.title.Substring(0, Math.Min(100, this.title.Length));

            Contract.Requires(this.title != null);

            String number = "";

            Random rnd = new Random();

            id = rnd.Next(1, 100000);

            number += id.ToString("D5");

            playCount = 0;

        }

        public void PrintVideoDetails()
        {

            Console.WriteLine("ID : " + id);

            Console.WriteLine("Title : " + title);

            Console.WriteLine("playCount : " + playCount);

        }
    }

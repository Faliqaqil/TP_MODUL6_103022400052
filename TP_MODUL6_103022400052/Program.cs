using System;

namespace TP_MODUL6_NIM
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Play Count: {this.playCount}");
            Console.WriteLine("----------------------------");
        }

        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Kenangan Manis");
            track1.IncreasePlayCount(200);
            track1.PrintTrackDetails();

            SayaMusicTrack track2 = new SayaMusicTrack("Bunga Abadi");
            track2.IncreasePlayCount(124);
            track2.PrintTrackDetails();

            SayaMusicTrack track3 = new SayaMusicTrack("Monolog");
            track3.IncreasePlayCount(324);
            track3.PrintTrackDetails();

            SayaMusicTrack track4 = new SayaMusicTrack("Glori Man UNTD");
            track4.IncreasePlayCount(2);
            track4.PrintTrackDetails();

            Console.WriteLine("Tekan tombol apapun untuk keluar.");
            Console.ReadKey();
        }
    }
}
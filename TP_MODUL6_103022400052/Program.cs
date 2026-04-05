using System;
using System.Diagnostics;

namespace TP_MODUL6_NIM
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter.");

            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000.");

            try
            {
                checked { this.playCount += count; }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi overflow pada playCount! Angka terlalu besar.");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {this.id} | Title: {this.title} | Play Count: {this.playCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<SayaMusicTrack> playlist = new List<SayaMusicTrack>();

            playlist.Add(new SayaMusicTrack("Kenangin Manis"));
            playlist.Add(new SayaMusicTrack("Bungan Abadi"));
            playlist.Add(new SayaMusicTrack("Monolog"));
            playlist.Add(new SayaMusicTrack("Glory MUTD"));
            playlist.Add(new SayaMusicTrack("Sial - Mahalini"));

            Console.WriteLine("=== DAFTAR PLAYLIST AWAL ===");
            foreach (var track in playlist)
            {
                track.PrintTrackDetails();
            }

            Console.WriteLine("\n=== UPDATE PLAY COUNT ===");

            playlist[0].IncreasePlayCount(500000);

            playlist[1].IncreasePlayCount(400000);

            playlist[2].IncreasePlayCount(700000);

            playlist[3].IncreasePlayCount(10000000);

            Console.WriteLine("\n=== SIMULASI OVERFLOW PADA: " + playlist[4].GetType().Name + " ===");
            for (int i = 0; i < 220; i++)
            {
                playlist[4].IncreasePlayCount(10000000);
            }

            Console.WriteLine("\n=== HASIL AKHIR SEMUA TRACK ===");
            foreach (var track in playlist)
            {
                track.PrintTrackDetails();
            }

            Console.WriteLine("\nTekan tombol apapun untuk keluar.");
            Console.ReadKey();
        }
    }
}
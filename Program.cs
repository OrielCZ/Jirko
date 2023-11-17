using System;
using System.Media;
using System.Numerics;


class Program
{
        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlaer = new SoundPlayer();
            musicPlaer.SoundLocation = filepath;
            musicPlaer.PlaySync();
        }
    private static void Main(string[] args)
    {
        {
            double i = 100000;

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Jirko!? ");
                PlayMusic("Jirko.wav");
            }
        }
    }
}
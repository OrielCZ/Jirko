using System;
using System.Media;
using System.Numerics;


namespace Jirko
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusic("Jirko.wav");
            Console.WriteLine("Plaing music");
        
        }

        public static void PlayMusic(string filepath)
        {   
            SoundPlayer musicPlaer = new SoundPlayer();
            musicPlaer.SoundLocation = filepath;
            musicPlaer.PlaySync();
                
        }
    }

}


/*
string input = "Jirko! ?";
double i = 100000;

for (int j = 0; j < i; j++)
{
    Console.Write(input + " ");
    Thread.Sleep(100);
}
*/
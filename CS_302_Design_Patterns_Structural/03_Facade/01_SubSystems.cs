using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Facade
{
    // Step 1: Define the subsystem components

    // Amplifier class
    public class Amplifier
    {
        public void TurnOn()
        {
            Console.WriteLine("Amplifier is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Amplifier is OFF");
        }
    }

    // DVDPlayer class
    public class DVDPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("DVD Player is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("DVD Player is OFF");
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Playing movie: {movie}");
        }
    }

    // Projector class
    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Projector is OFF");
        }
    }

    // Lights class
    public class Lights
    {
        public void Dim()
        {
            Console.WriteLine("Lights are dimmed");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lights are ON");
        }
    }

    // Screen class
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen is down");
        }

        public void Up()
        {
            Console.WriteLine("Screen is up");
        }
    }
}

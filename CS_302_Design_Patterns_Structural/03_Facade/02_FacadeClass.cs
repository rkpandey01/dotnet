using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Facade
{
    // Step 2: Create the Facade class

    // HomeTheaterFacade class
    public class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private DVDPlayer dvdPlayer;
        private Projector projector;
        private Lights lights;
        private Screen screen;

        public HomeTheaterFacade()
        {
            // Initialize the subsystem components
            amplifier = new Amplifier();
            dvdPlayer = new DVDPlayer();
            projector = new Projector();
            lights = new Lights();
            screen = new Screen();
        }

        // Provide a simplified interface for watching a movie
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            amplifier.TurnOn();
            dvdPlayer.TurnOn();
            projector.TurnOn();
            lights.Dim();
            screen.Down();
            dvdPlayer.PlayMovie(movie);
        }

        // Provide a simplified interface for stopping the movie
        public void StopMovie()
        {
            Console.WriteLine("Shutting down the home theater system...");
            amplifier.TurnOff();
            dvdPlayer.TurnOff();
            projector.TurnOff();
            lights.TurnOn();
            screen.Up();
        }
    }
}

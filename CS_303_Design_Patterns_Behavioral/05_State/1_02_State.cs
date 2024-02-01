using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
    public class PlayingState : IAudioPlayerState
    {
        public void Play(AudioPlayer context)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(AudioPlayer context)
        {
            Console.WriteLine("Pausing the audio.");
            context.ChangeState(new PausedState());
        }

        public void Stop(AudioPlayer context)
        {
            Console.WriteLine("Stopping the audio.");
            context.ChangeState(new StoppedState());
        }
    }

    public class PausedState : IAudioPlayerState
    {
        public void Play(AudioPlayer context)
        {
            Console.WriteLine("Resuming the audio.");
            context.ChangeState(new PlayingState());
        }

        public void Pause(AudioPlayer context)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(AudioPlayer context)
        {
            Console.WriteLine("Stopping the audio.");
            context.ChangeState(new StoppedState());
        }
    }

    public class StoppedState : IAudioPlayerState
    {
        public void Play(AudioPlayer context)
        {
            Console.WriteLine("Starting to play.");
            context.ChangeState(new PlayingState());
        }

        public void Pause(AudioPlayer context)
        {
            Console.WriteLine("Cannot pause, audio is stopped.");
        }

        public void Stop(AudioPlayer context)
        {
            Console.WriteLine("Already stopped.");
        }
    }

}

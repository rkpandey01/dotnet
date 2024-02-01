using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
    public class AudioPlayer
    {
        private IAudioPlayerState currentState;

        public AudioPlayer()
        {
            // Initialize the player with the Stopped state
            currentState = new StoppedState();
        }

        public void ChangeState(IAudioPlayerState newState)
        {
            currentState = newState;
        }

        public void Play()
        {
            currentState.Play(this);
        }

        public void Pause()
        {
            currentState.Pause(this);
        }

        public void Stop()
        {
            currentState.Stop(this);
        }
    }

}

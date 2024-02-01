using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_State
{
    public interface IAudioPlayerState
    {
        void Play(AudioPlayer context);
        void Pause(AudioPlayer context);
        void Stop(AudioPlayer context);
    }

}

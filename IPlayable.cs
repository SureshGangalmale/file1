using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal interface IPlayable
    {
        void play();
    }
    class VideoPlayer:IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Video...");
        }

    }

    class MusicPlayer:IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing Music...");
        }
    }
    internal class demo
    {
        static void Main()
        {
            IPlayable video=new VideoPlayer();
            video.play();
            IPlayable music=new MusicPlayer();
            music.play();
        }
    }
}

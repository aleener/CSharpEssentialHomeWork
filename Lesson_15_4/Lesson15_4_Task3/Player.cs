using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task3
{
    internal class Player : IPlayable,IRecodable
    {
        public void Play() 
        {
            Console.WriteLine("Plying");
        }
        public void Record()
        {
            Console.WriteLine("Recording");
        }
        public void Pause()
        {
            Console.WriteLine("Paused");
        }
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
}

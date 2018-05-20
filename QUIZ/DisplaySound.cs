using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    public class DisplaySound
    {
        private SoundPlayer simpleSound;
        public void playSimpleSound(System.IO.UnmanagedMemoryStream s)
        {
            simpleSound = new SoundPlayer(s);

            simpleSound.Play();
        }
        public void stop()
        {
            simpleSound.Stop();
        }
        public void playInLoop(System.IO.UnmanagedMemoryStream s)
        {
            simpleSound = new SoundPlayer(s);
            simpleSound.PlayLooping();
        }
    }
}

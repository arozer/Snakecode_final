using WMPLib;
namespace Snakecode
{
    public class Sounds
    {
       WindowsMediaPlayer player = new WindowsMediaPlayer();
       private string pathToMedia;

       public Sounds(string pathToResources)
       {
           pathToMedia = pathToResources;
       }

       public void Play()
       {
           player.URL = pathToMedia + "Sound_19341.mp3";
           player.settings.volume = 10;
           player.controls.play();
       }

       public void PlayEat()
       {
           player.URL = pathToMedia + "Special_Attack_02.wav";
           player.settings.volume = 50;
           player.controls.play();
       }


       public void Stop()
       {
           player.URL = pathToMedia + "Sound_19341.mp3";
           player.controls.stop();
       }


    }
}
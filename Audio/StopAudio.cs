
public class StopAudio : AudioPlayer
{
    public void Stop(AudioList AudioList){
      audioList[AudioList].Stop();
    }
}

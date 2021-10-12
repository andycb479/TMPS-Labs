namespace Core.VideoStream.Proxy
{
     public interface ISpotVideo
     {
          void Play();
          public SnapShot GetVideoSnapshot();
          public string GetVideoTitle();
     }
}

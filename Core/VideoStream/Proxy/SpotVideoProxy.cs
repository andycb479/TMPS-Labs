namespace Core.VideoStream.Proxy
{
     public class SpotVideoProxy : ISpotVideo
     {
          private readonly SnapShot _videoSnapshot;
          private readonly string _videoTitle;
          private RealSpotVideo _video;

          public SpotVideoProxy(SnapShot videoSnapshot, string videoTitle)
          {
               _videoSnapshot = videoSnapshot;
               _videoTitle = videoTitle;
          }

          public void Play()
          {
               _video ??= new RealSpotVideo(_videoSnapshot, _videoTitle);
               _video.Play();
          }
          public string GetVideoTitle()
          {
               return _videoTitle;
          }

          public SnapShot GetVideoSnapshot()
          {
               return _videoSnapshot;
          }
     }
}
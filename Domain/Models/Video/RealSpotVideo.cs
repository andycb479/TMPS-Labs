using System;

namespace Domain.Models.Video
{
     public class RealSpotVideo : ISpotVideo
     {
          private readonly SnapShot _videoSnapshot;
          private readonly string _videoTitle;

          public RealSpotVideo(SnapShot videoSnapshot, string videoTitle)
          {
               _videoSnapshot = videoSnapshot;
               _videoTitle = videoTitle;
               LoadVideo();
          }
          public void Play()
          {
               Console.WriteLine("Starting the video.");
          }

          public SnapShot GetVideoSnapshot()
          {
               return _videoSnapshot;
          }

          public string GetVideoTitle()
          {
               return _videoTitle;
          }

          private void LoadVideo()
          {
               Console.WriteLine($"Loading video with title {_videoTitle} from database.");
          }
     }
}
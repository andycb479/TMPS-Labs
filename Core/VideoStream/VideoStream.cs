using System;
using Core.VideoStream.Proxy;

namespace Core.VideoStream
{
     public class VideoStream : IStream
     {
          public void Write(ISpotVideo video)
          {
               Console.WriteLine($"Storing the video with title {video.GetVideoTitle()}");
          }
     }
}

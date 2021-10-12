using System;
using Core.VideoStream.Proxy;

namespace Core.VideoStream
{
     public class CompressedVideoStream : IStream
     {
          private readonly IStream _stream;
          public CompressedVideoStream(IStream stream)
          {
               _stream = stream;
          }
          public void Write(ISpotVideo video)
          {
               var compressed = Compress(video);
               _stream.Write(compressed);
          }

          private ISpotVideo Compress(ISpotVideo video)
          {
               Console.WriteLine($"Compressing the video with title {video.GetVideoTitle()}");
               return video;
          }


     }
}
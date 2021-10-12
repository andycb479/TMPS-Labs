using System;
using Core.VideoStream.Proxy;

namespace Core.VideoStream
{
     public class EncodedVideoStream : IStream
     {
          private readonly IStream _stream;
          public EncodedVideoStream(IStream stream)
          {
               _stream = stream;
          }
          public void Write(ISpotVideo video)
          {
               var encoded = Encode(video);
               _stream.Write(video);
          }

          private ISpotVideo Encode(ISpotVideo video)
          {
               Console.WriteLine($"Encoding video with the title {video.GetVideoTitle()}");
               return video;
          }

          
     }
}
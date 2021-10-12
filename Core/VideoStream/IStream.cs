using Core.VideoStream.Proxy;

namespace Core.VideoStream
{
     public interface IStream
     {
          void Write(ISpotVideo video);
     }
}
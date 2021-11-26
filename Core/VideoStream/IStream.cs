using Domain.Models.Video;

namespace Core.VideoStream
{
     public interface IStream
     {
          void Write(ISpotVideo video);
     }
}
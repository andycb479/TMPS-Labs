using System.Collections.Generic;

namespace Domain.Models.Video
{
     public class VideoLibrary
     {
          private readonly Dictionary<string, ISpotVideo> _spotVideos = new Dictionary<string, ISpotVideo>();
          public void AddVideo(ISpotVideo video )
          {
               _spotVideos[video.GetVideoTitle()] = video;
          }

          public void OpenVideo(string videoTitle)
          {
               _spotVideos[videoTitle].Play();
          }

     }
}
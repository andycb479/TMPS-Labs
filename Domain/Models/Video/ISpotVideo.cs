namespace Domain.Models.Video
{
     public interface ISpotVideo
     {
          void Play();
          public SnapShot GetVideoSnapshot();
          public string GetVideoTitle();
     }
}

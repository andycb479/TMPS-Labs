using Data.Database;
using System;
using Core.VideoStream;
using Core.VideoStream.Proxy;
using Utility.NotificationManager;

namespace Client
{
     class Program
     {
          public static void Main(string[] args)
          {


               var reservees = new ReserveesDb().Reservees;
               var restaurants = new RestaurantsDb().Restaurants;
               var nightClubs = new NightClubsDb().NightClubs;
               var reservations = new ReservationsDb(restaurants, reservees).Reservations;

               // Proxy pattern implementation.

               var KFCShowcaseSnapshot = new SnapShot(new byte[128]);
               var VasabiShowcaseSnapshot = new SnapShot(new byte[128]);
               var AndysInteriorSnapshot = new SnapShot(new byte[128]);

               var spotVideos = new VideoLibrary();

               spotVideos.AddVideo(new SpotVideoProxy(KFCShowcaseSnapshot, "KFC Add"));
               spotVideos.AddVideo(new SpotVideoProxy(VasabiShowcaseSnapshot, "Vasabi Showcase"));
               spotVideos.AddVideo(new SpotVideoProxy(AndysInteriorSnapshot, "Andy's Interior"));

               spotVideos.OpenVideo("KFC Add");

               Console.WriteLine("\n\n");

               // Decorator pattern implementation

               StoreVideoInCloud(
                    new CompressedVideoStream(
                         new EncodedVideoStream(
                              new VideoStream()
                              )
                         ),

                    new SpotVideoProxy(new SnapShot(new byte[128]), "Vasabi Showcase"));

               Console.WriteLine("\n\n");

               // Facade pattern use.

               var notificationService = new NotificationService();
               notificationService.Send("Hello there.", reservees[2].Phone);


          }
          private static void StoreVideoInCloud(IStream stream, ISpotVideo video)
          {
               stream.Write(video);
          }
     }
}

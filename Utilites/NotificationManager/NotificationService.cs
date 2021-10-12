using System;
using Reservation_System.Facade;
using Utility.Logger;

namespace Utility.NotificationManager
{
     public class NotificationService
     {

          public void Send(string message, string target)
          {
               var server = new NotificationServer();
               var connection = server.Connect("ip");
               var authToken = server.Authenticate("appId", "key");
               server.Send(authToken, new Message(message), target);
               connection.Disconnect();
          }
     }
}

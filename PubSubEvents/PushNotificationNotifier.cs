using System;

namespace PubSubEvents
{
    class PushNotificationNotifier
    {
        public static void SendPushNotification(object e, VideoArgs args)
        {
            Console.WriteLine("Sending Push Notification about " + args.Video.Title);
        }
    }
}
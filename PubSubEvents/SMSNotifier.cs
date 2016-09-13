using System;

namespace PubSubEvents
{
    class SMSNotifier
    {
        public static void SendSMS(object e, VideoArgs args)
        {
            Console.WriteLine("Sending SMS about " + args.Video.Title);
        }
    } 
}
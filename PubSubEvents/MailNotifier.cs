using System;

namespace PubSubEvents
{
    class MailNotifier
    {
        public static void SendMail(object e, VideoArgs args)
        {
            Console.WriteLine("Sending Email About "+args.Video.Title);
        }
    }
}
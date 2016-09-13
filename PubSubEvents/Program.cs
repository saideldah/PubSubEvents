using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder ve = new VideoEncoder();

            ve.VideoEncoded += PushNotificationNotifier.SendPushNotification;
            ve.VideoEncoded += SMSNotifier.SendSMS;
            ve.VideoEncoded += MailNotifier.SendMail;
            ve.Encode(new Video() {Title = "My Video"});

        }
    }
}

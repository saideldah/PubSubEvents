using System;
using System.Threading;

namespace PubSubEvents
{
    class VideoEncoder
    {
        //public delegate void VideoEncoderEvenetHandler(object e, VideoArgs args);

        //public VideoEncoderEvenetHandler VideoEncoded;
        public EventHandler<VideoArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            VideoEncoded(this, new VideoArgs() { Video = video});
            Thread.Sleep(3000);
        }
    }
}
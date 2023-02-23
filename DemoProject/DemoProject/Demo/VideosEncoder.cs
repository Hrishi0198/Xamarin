using System;
using System.Threading;

namespace DemoProject
{
	public class VideosEncoder
	{

		public delegate void VideosEncoderEventHandler(object source, EventArgs args);

		public event VideosEncoderEventHandler VideosEncoded;

        public void Encode(Video video)
		{
			Console.Write(" encoding the task.....");
            Thread.Sleep(3000);

			OnVideosEncoder();
        }
		protected virtual void OnVideosEncoder()
		{
			if (VideosEncoded != null)
				VideosEncoded(this, EventArgs.Empty);
		}
    }
}


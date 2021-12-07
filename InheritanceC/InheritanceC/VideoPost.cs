using System;
using System.Threading;

namespace InheritanceC
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, bool isPublic, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ISPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}s - {3} by {4}", this.ID, this.Title, this.Length, this.VideoURL, this.SendByUserName);
        }
    }
}

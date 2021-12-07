using System;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool ISPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "This is my post";
            ISPublic = true;
            SendByUserName = "Bilash Proshad";
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ISPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.ISPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }

    }
}

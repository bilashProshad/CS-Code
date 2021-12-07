using System;

namespace InheritanceC
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ISPublic = isPublic;
            
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - URL: {3}", this.ID, this.Title, this.SendByUserName, this.ImageURL);
        }

    }
}

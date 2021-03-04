using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ImagePost:Post //ImagePost derives from post and adds a property(ImageURL) and 2 constructors
    {
        public string ImageURL { get; set; }
        public ImagePost() { } //empty constructor
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;// our own and post doesnt know about this
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2} and link {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}

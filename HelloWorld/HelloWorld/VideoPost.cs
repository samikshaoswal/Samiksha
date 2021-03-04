using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class VideoPost:Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic,int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.Length = length;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - by - {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
    }
}

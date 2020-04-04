using System;
using System.Collections.Generic;
using System.Text;

namespace JaggedArray
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // Property ImageUrl is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} -  by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}

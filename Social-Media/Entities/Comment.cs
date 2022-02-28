using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Entities
{
    internal class Comment
    {
        public string Text { get; set; }
        
        public Comment()
        {
        }

        public Comment(string txt)
        {
            Text = txt;
        }

    }
}

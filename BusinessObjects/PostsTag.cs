using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class PostsTag
    {
        public int PostTagId { get; set; }
        public int TagId { get; set; }

        public virtual Post PostTag { get; set; }
        public virtual Tag Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Comment
    {
        public string CommentId { get; set; }
        public string Author { get; set; }
        public int? Award { get; set; }
        public string Context { get; set; }
        public string PublishTime { get; set; }
        public int? Status { get; set; }
        public int? PostComment { get; set; }
        public string UserId { get; set; }

        public virtual Post PostCommentNavigation { get; set; }
        public virtual TblUser User { get; set; }
    }
}

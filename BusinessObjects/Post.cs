using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public int? Approve { get; set; }
        public string ApproveTime { get; set; }
        public string AppovedBy { get; set; }
        public string PostAuthor { get; set; }
        public int? Award { get; set; }
        public int? PostCategoryId { get; set; }
        public string PostComment { get; set; }
        public string Image { get; set; }
        public string PostContent { get; set; }
        public int? Status { get; set; }
        public int? PostSubjectId { get; set; }
        public int? PostTagId { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public int? SubjectId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

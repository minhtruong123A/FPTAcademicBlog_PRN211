using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblUser
    {
        public TblUser()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public string UserId { get; set; }
        public int? Award { get; set; }
        public string Birthdate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Major { get; set; }
        public int? NumberOfPosts { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public int? Status { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}

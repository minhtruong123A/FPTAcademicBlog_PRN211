using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Subject
    {
        public Subject()
        {
            Posts = new HashSet<Post>();
        }

        public int SubjectId { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string SubjecName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}

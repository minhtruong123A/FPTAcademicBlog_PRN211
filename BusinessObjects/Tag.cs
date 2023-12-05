using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Tag
    {
        public int TagId { get; set; }
        public int? Status { get; set; }
        public string TagDescription { get; set; }
        public string TagName { get; set; }
    }
}

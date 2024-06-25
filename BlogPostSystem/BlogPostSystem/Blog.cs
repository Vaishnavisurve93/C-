using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostSystem
{
        public class Blog
        {
        [Key]
        public int BlogId { get; set; }
            public string BlogName { get; set; }
            public string BlogType { get; set; }
            public string BlogHeader { get; set; }
            public string BlogDescription { get; set; }
            public string age { get; set; }

            public virtual List<Post> Posts { get; set; }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndTest
{
    
    public class UserPostReporting
    {
        [Key]
        public int PostId { get; set; }
        public string PostDescription { get; set; }

        public string CommentsDes { get; set; }

        public string UserFullName { get; set; }

        public string CommentDateTime { get; set; }
        public int LikeNo { get; set; }
        public int DisLikeNo { get; set; }

    }
}

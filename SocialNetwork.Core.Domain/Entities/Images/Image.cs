using SocialNetwork.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Entities.Posts;
using SocialNetwork.Core.Domain.Entities.Users;

namespace SocialNetwork.Core.Domain.Entities.Images
{
    public class Image : Base
    {
        public string FileName { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public int userId { get; set; }

        public int postId { get; set; }

        public Post post { get; set; } = null!; 
        public User user { get; set; } = null!;
    }
}

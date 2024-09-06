using SocialNetwork.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Entities.Posts;
using SocialNetwork.Core.Domain.Entities.Users;

namespace SocialNetwork.Core.Domain.Entities.Likes
{
    public class Like : Base
    {
        public int userId { get; set; }
        public int postId { get; set; }

        public User user { get; set; } = null!;
        public Post post { get; set; } = null!;
    }
}

using SocialNetwork.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Entities.Posts;
using SocialNetwork.Core.Domain.Entities.Users;

namespace SocialNetwork.Core.Domain.Entities.Comments
{
    public class Comment : Base
    {
        public string PostComment { get; set; } = string.Empty;
        public int userId { get; set; }
        public int postId { get; set; }

        public Post Post { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}

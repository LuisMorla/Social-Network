using SocialNetwork.Core.Domain.Common;
using SocialNetwork.Core.Domain.Entities.Images;
using SocialNetwork.Core.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Entities.Comments;

namespace SocialNetwork.Core.Domain.Entities.Posts
{
    public class Post : Base
    {
        public string PostContent { get; set; } = string.Empty;
        public int userId { get; set; }
        public int? ImageId { get; set; }

        public ICollection<Image>? Images { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Comment>? Comments { get; set; }
    }
}

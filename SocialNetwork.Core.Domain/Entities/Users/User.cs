using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Common;
using SocialNetwork.Core.Domain.Entities.Friends;
using SocialNetwork.Core.Domain.Entities.Posts;
using SocialNetwork.Core.Domain.Entities.Images;
using SocialNetwork.Core.Domain.Entities.Likes;
using SocialNetwork.Core.Domain.Entities.Comments;




namespace SocialNetwork.Core.Domain.Entities.Users
{
    public class User : Base
    {
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string CoverPicture { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;

        // Navigation Properties

        public ICollection<Friend>? Friends { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comment>? Comments { get; set;}

    }
}

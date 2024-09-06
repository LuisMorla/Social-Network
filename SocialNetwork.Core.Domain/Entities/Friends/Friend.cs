using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Core.Domain.Common;
using SocialNetwork.Core.Domain.Entities.Users;

namespace SocialNetwork.Core.Domain.Entities.Friends
{
    public class Friend : Base
    {
        public int userId { get; set; }
        public int friendId { get; set; }

        public User user { get; set; } = null!;
        public User friend { get; set; } = null!;
    }
}

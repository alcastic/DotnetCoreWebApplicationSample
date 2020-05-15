using System.Collections.Generic;
using System.Linq;

namespace DotnetCoreWebApplication.Model
{
    public class UserState
    {
        public User OwnerUser { get; set; }
        public List<Comment> Comments { get; set; }

        public UserState(User ownerUser, List<Comment> comments)
        {
            OwnerUser = ownerUser;
            Comments = comments;
        }
    }
}
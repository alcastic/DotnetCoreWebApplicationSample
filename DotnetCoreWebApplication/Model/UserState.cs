using System.Collections.Generic;
using System.Linq;

namespace DotnetCoreWebApplication.Model
{
    public class UserState
    {
        public User OwnerUser { get; set; }
        
        public string State { get; set; }
        public List<Comment> Comments { get; set; }

        public UserState(User ownerUser, string state, List<Comment> comments)
        {
            OwnerUser = ownerUser;
            State = state;
            Comments = comments;
        }
    }
}
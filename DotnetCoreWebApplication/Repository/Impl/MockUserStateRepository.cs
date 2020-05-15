using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository.Impl
{
    public class MockUserStateRepository : IUserStateRepository
    {
        public IEnumerable<UserState> FindByUserId(int userId)
        {
            var rootUser = new User(0, "alcastic", "Alexander");

            var userState = new UserState(rootUser,
                new List<Comment>()
                {
                    new Comment(-1, "Hi!"),
                    new Comment(-1, "Well Done!")
                });

            return new List<UserState> {userState};
        }
    }
}
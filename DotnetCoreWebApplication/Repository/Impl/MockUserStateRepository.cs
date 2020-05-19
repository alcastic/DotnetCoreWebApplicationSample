using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository.Impl
{
    public class MockUserStateRepository : IUserStateRepository
    {
        public UserState FindByUserId(int userId)
        {
            var rootUser = new User(0, "alcastic", "Alexander");

            return new UserState(rootUser,"At home!",
                new List<Comment>()
                {
                    new Comment(-1, "Hi!"),
                    new Comment(-1, "Well Done!")
                });
        }
    }
}
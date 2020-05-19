using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository.Impl
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return new List<User>
            {
                new User(0, "alcastic", "Alexander"),
                new User(1, "freeman", "Freeman")
            };
        }
    }
}
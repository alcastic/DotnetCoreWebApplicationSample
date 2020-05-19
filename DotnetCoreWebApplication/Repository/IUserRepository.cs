using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
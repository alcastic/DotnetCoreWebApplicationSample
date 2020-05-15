using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository
{
    public interface IUserStateRepository
    {
        IEnumerable<UserState> FindByUserId(int userId);
    }
}
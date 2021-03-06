using System.Collections.Generic;
using DotnetCoreWebApplication.Model;

namespace DotnetCoreWebApplication.Repository
{
    public interface IUserStateRepository
    {
        UserState FindByUserId(int userId);
    }
}
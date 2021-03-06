using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Services
{
    public interface IAuthService
    {
        Task<bool> Login(string username, string password);
        Task Logout();
    }
}

using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface IAdminRepository : IAsyncRepository<Admin>
    {
    }
}

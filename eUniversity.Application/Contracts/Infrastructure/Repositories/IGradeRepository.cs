using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface IGradeRepository : IAsyncRepository<Grade>
    {
        Task<Grade> GetDefaultGrade();
    }
}

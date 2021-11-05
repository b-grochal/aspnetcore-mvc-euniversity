using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Contracts.Persistence
{
    public interface IGradeRepository : IAsyncRepository<Grade>
    {
    }
}

using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);

        Task AddRnageAsync(IList<Task> entities);

        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);


    }
}

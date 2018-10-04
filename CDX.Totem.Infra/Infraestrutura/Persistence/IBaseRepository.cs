using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;

namespace CDX.Totem.Core.Infraestrutura.Persistence
{
    public interface IBaseRepository<T> where T : class
    {
        Database Database { get; }

        IQueryable<T> ObterTodos();

        IQueryable<TJoinEntity> ObterTodos<TJoinEntity>() where TJoinEntity : class;
    }
}

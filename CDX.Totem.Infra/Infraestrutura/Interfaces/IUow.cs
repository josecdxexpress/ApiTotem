using System.Threading.Tasks;

namespace CDX.Totem.Core.Infraestrutura.Interfaces
{
    public interface IUow
    {
        Task CommitAsync();
        void Rollback();
    }
}

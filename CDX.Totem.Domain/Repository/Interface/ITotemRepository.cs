using CDX.Totem.Core.Infraestrutura.Services.Tos;
using CDX.Totem.Domain.Models;
using CDX.Totem.Domain.Models.To;
using CDX.Totem.Domain.Models.To.Filtro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CDX.Totem.Domain.Repository.Interface
{
    /// <summary>
    /// Interface de repository para operações com a entidade nota fiscal.
    /// </summary>
    public interface ITotemRepository
    {
        /// <summary>
        /// Obtem todos por id
        /// </summary>
        Task<TotemConfig> Obter(string serial);

        TotemConfig Adicionar(TotemConfig totemConfig);
    }
}


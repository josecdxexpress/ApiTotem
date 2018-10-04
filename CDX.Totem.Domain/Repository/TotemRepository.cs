using CDX.Totem.Core.Infraestrutura.Enum;
using CDX.Totem.Core.Infraestrutura.Services.Tos;
using CDX.Totem.Domain.Infraestrutura.Conexao;
using CDX.Totem.Domain.Models;
using CDX.Totem.Domain.Models.To;
using CDX.Totem.Domain.Models.To.Filtro;
using CDX.Totem.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDX.Totem.Domain.Repository
{
    public class TotemRepository : ITotemRepository
    {
        private readonly Contexto _db;

        public TotemRepository(Contexto context)
        {
            _db = context;
        }

        public async Task<TotemConfig> Obter(string serial)
        {
            var totemObj = _db.TotemConfig
                            .Where(p => (string.IsNullOrEmpty(serial) || EF.Functions.Like(p.Serial, $"%{serial}%")) && p.Situacao == SituacaoEnum.Ativo)
            .FirstOrDefaultAsync();

            return await totemObj;
        }

        public TotemConfig Adicionar(TotemConfig totemConfig)
        {
            _db.TotemConfig.Add(totemConfig);
            _db.SaveChanges();

            return totemConfig;
        }
    }
}
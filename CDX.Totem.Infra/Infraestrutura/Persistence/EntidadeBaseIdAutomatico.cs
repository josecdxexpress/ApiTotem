using CDX.Totem.Core.Infraestrutura.Enum;
using CDX.Totem.Core.Infraestrutura.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDX.Totem.Core.Infraestrutura.Persistence
{
    public abstract class BaseEntidade : IEntidade
    {
        [Key]
        public int Id { get; set; }

        public int? UsuarioId { get; set; }

        public DateTime? DataCadastro { get; set; } = DateTime.UtcNow;

        public DateTime? DataAlteracao { get; set; }

        public SituacaoEnum Situacao { get; set; } = SituacaoEnum.Ativo;
    }
}

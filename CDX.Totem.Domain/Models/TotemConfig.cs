using CDX.Totem.Core.Infraestrutura.Enum;
using CDX.Totem.Core.Infraestrutura.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDX.Totem.Domain.Models
{
    public class TotemConfig: BaseEntidade
    {
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(10)]
        public string Codigo { get; set; }

        [Required]
        public int EmpresaId { get; set; }

        [Required]
        public int FusoHorario { get; set; }

        [MaxLength(20)]
        public string Versao { get; set; }

        [MaxLength(20)]
        public string Contratante { get; set; }

        [MaxLength(20)]
        public string Estabelecimento { get; set; }

        [MaxLength(50)]
        public string Serial { get; set; }

        [MaxLength(80)]
        public string InformativoH1 { get; set; }

        [MaxLength(80)]
        public string InformativoH2 { get; set; }

        [MaxLength(80)]
        public string InformativoH3 { get; set; }

        [MaxLength(80)]
        public string ProgressBarTextoH1 { get; set; }

        [MaxLength(80)]
        public string ProgressBarTextoH2 { get; set; }

        public int LimiteInatividade { get; set; }

        [MaxLength(20)]
        public string ChaveAcessoSinPag { get; set; }

        [MaxLength(50)]
        public string Logotipo { get; set; }

        public bool Logado { get; set; }

        public bool AtendeDetran { get; set; }

        public bool AtendePatios { get; set; }

        [NotMapped]
        public Output Retorno { get; set; } = new Output();
    }
}

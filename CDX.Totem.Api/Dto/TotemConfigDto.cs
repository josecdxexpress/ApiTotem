using CDX.Totem.Core.Infraestrutura.Enum;
using CDX.Totem.Domain.Models;
using Microsoft.AspNetCore.Hosting;
using System;

namespace CDX.Totem.Api.Dto
{
    public class TotemConfigDto
    {
        public TotemConfigDto()
        {
        }

        public TotemConfigDto(string hostingEnvironment, TotemConfig totem)
        {
            if (totem == null)
            {
                return;
            }


            Id = totem.Id;
            UsuarioId = totem.UsuarioId;
            DataCadastro = totem.DataCadastro;
            DataAlteracao = totem.DataAlteracao;
            Nome = totem.Nome;
            Codigo = totem.Codigo;
            FusoHorario = totem.FusoHorario;
            Versao = totem.Versao;
            Contratante = totem.Contratante;
            Estabelecimento = totem.Estabelecimento;
            Serial = totem.Serial;
            InformativoH1 = totem.InformativoH1;
            InformativoH2 = totem.InformativoH2;
            InformativoH3 = totem.InformativoH3;
            ProgressBarTextoH1 = totem.ProgressBarTextoH1;
            ProgressBarTextoH2 = totem.ProgressBarTextoH2;
            LimiteInatividade = totem.LimiteInatividade;
            ChaveAcessoSinPag = totem.ChaveAcessoSinPag;
            AtendeDetran = totem.AtendeDetran;
            AtendePatios = totem.AtendePatios;

            if (!string.IsNullOrEmpty(totem.Logotipo))
            {
                Logotipo = hostingEnvironment + "/resources/" + totem.Logotipo;
            }
            else
            {
                Logotipo = hostingEnvironment + "/resources/logo-detran.png";
            }

            Logado = totem.Logado;
            Situacao = totem.Situacao;
            Retorno = new Output() { Status = true };
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? DataCadastro { get; set; } 
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int EmpresaId { get; set; }
        public int FusoHorario { get; set; }
        public string Versao { get; set; }
        public string Contratante { get; set; }
        public string Estabelecimento { get; set; }
        public string Serial { get; set; }
        public string InformativoH1 { get; set; }
        public string InformativoH2 { get; set; }
        public string InformativoH3 { get; set; }
        public string ProgressBarTextoH1 { get; set; }
        public string ProgressBarTextoH2 { get; set; }
        public int LimiteInatividade { get; set; }
        public string ChaveAcessoSinPag { get; set; }
        public string Logotipo { get; set; }
        public bool Logado { get; set; }
        public bool AtendeDetran { get; set; }
        public bool AtendePatios { get; set; }
        public SituacaoEnum Situacao { get; set; } = SituacaoEnum.Ativo;
        public Output Retorno { get; set; } = new Output();
    }
}

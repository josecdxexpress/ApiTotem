using CDX.Totem.Core.Infraestrutura.Services.Tos;
using System;
using System.Collections.Generic;
namespace CDX.Totem.Domain.Models.To.Filtro
{
    public class RequisicaoFiltroTo : PesquisaTo
    {
        public string NumeroNota { get; set; }

        public int? Referencia { get; set; }
    }
}

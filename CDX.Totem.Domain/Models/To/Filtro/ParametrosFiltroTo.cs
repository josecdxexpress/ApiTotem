using CDX.Totem.Core.Infraestrutura.Services.Tos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDX.Totem.Domain.Models.To.Filtro
{
    public class ParametrosFiltroTo : PesquisaTo
    {
        public int? CidadeId { get; set; }

        public int? UsuarioId { get; set; }
    }
}


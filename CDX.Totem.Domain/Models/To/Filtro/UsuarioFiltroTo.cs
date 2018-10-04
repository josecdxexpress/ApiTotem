using CDX.Totem.Core.Infraestrutura.Services.Tos;

namespace CDX.Totem.Domain.Models.To.Filtro
{
    public class UsuarioFiltroTo: PesquisaTo
    {
        public string Nome { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }
    }
}

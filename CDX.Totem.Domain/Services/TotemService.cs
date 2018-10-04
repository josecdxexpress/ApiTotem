using CDX.Totem.Domain.Models;
using CDX.Totem.Domain.Repository.Interface;
using CDX.Totem.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CDX.Totem.Domain.Services
{
    public class TotemService: ITotemService
    {
        private readonly ITotemRepository _totemRepository;

        public TotemService(ITotemRepository totemRepository)
        {
            _totemRepository = totemRepository;
        }

        /// <summary>
        /// Obtem a configuração do totem caso não encontre adiciona.
        /// </summary>
        /// <param name="serial"></param>
        /// <returns></returns>
        public async Task<TotemConfig> Obter(string serial)
        {
            var totemConfig = _totemRepository.Obter(serial).Result;

            if (totemConfig == null)
            {
                /* Padrão para novos totem */
                var obj = new TotemConfig()
                {
                    Nome = "Detran",
                    Codigo = "99999",
                    EmpresaId = 1,
                    FusoHorario = 1,
                    Versao = "0.2 Beta",
                    Contratante = "Detran",
                    Estabelecimento = "Detran",
                    Serial = serial.Trim().ToUpper(),
                    InformativoH1 = "Consulte os débitos a pagar para a retirada do seu veículo",
                    InformativoH2 = "em até 10 vezes",
                    InformativoH3 = "",
                    LimiteInatividade = 10,
                    ChaveAcessoSinPag = "CHAVECDXEXPRESS2018",
                    Logotipo = "logo-detran.png",
                    Logado = false
                };

                var objTotemConfig = _totemRepository.Adicionar(obj);

                return objTotemConfig;
            }

            return totemConfig;
        }
    }
}

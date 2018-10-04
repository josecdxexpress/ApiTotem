using CDX.Totem.Api.Dto;
using CDX.Totem.Core.Infraestrutura.Api;
using CDX.Totem.Domain.Models;
using CDX.Totem.Domain.Repository.Interface;
using CDX.Totem.Domain.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CDX.Totem.Api.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class InicializacaoController : Controller
    {
        private readonly ITotemService _totemService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public InicializacaoController(ITotemService totemService, IHostingEnvironment hostingEnvironment)
        {
            _totemService = totemService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<OkObjectResult> Get(string serial)
        {
            var resultado = new Retorno<TotemConfig>() { Status = ResultadoOperacao.Sucesso };

            string webRootPath = _hostingEnvironment.WebRootPath;
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            var totem = new TotemConfig();

            try
            {
                totem = _totemService.Obter(serial).Result;
               return Ok(new TotemConfigDto(_hostingEnvironment.ContentRootPath, totem));
            }
            catch (Exception)
            {
                return Ok(totem);
            }
        }
    }
}

using CDX.Totem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CDX.Totem.Domain.Services.Interface
{
    public interface ITotemService
    {
        Task<TotemConfig> Obter(string serial);
    }
}

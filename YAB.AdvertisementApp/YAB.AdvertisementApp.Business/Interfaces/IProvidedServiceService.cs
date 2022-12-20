using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.Business.Interfaces
{
    public interface IProvidedServiceService :
        IService<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos.Interfaces;

namespace YAB.AdvertisementApp.Dtos
{
    public class AppRoleCreateDto:IDto
    {
        public string Definition { get; set; }
    }
}

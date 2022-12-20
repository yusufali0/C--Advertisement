using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos.Interfaces;

namespace YAB.AdvertisementApp.Dtos
{
    public class AppRoleListDto:IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}

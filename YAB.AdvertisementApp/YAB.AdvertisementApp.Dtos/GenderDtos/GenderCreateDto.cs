using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos.Interfaces;

namespace YAB.AdvertisementApp.Dtos
{
    public class GenderCreateDto : IDto
    {
        //gender create etmicez fakat yapı gereği yazıldı
        public string Definition { get; set; }
    }
}

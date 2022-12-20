﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos.Interfaces;

namespace YAB.AdvertisementApp.Dtos
{
    public class AppUserLoginDto:IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

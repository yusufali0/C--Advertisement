﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class GenderProfile:Profile
    {
        public GenderProfile()
        {
            CreateMap<Gender, GenderListDto>().ReverseMap();
            CreateMap<Gender, GenderCreateDto>().ReverseMap();
            CreateMap<Gender, GenderUpdateDto>().ReverseMap();
        }
    }
}

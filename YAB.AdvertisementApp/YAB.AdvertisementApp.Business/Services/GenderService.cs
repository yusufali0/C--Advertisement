using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Business.Interfaces;
using YAB.AdvertisementApp.DataAccess.UnitOfWork;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>,IGenderService
    {
        public GenderService(IMapper mapper,IValidator<GenderCreateDto> createDtoValidator,IValidator<GenderUpdateDto>updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {

        }
    }
}

﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Dtos;

namespace YAB.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementCreateDtoValidator : AbstractValidator<AdvertisementCreateDto>
    {
        public AdvertisementCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}

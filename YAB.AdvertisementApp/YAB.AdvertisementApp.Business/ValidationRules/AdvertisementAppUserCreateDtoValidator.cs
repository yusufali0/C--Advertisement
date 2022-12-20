using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Common.Enums;
using YAB.AdvertisementApp.Dtos;

namespace YAB.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            this.RuleFor(x => x.AdvertisementAppUserStatusId).NotEmpty();
            this.RuleFor(x => x.AdvertisementId).NotEmpty();
            this.RuleFor(x => x.AppUserId).NotEmpty();
            this.RuleFor(x => x.CvPath).NotEmpty().WithMessage("Bir CV Dosyası Seçiniz");
            this.RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusId == (int)MilitaryStatusType.Tecilli).WithMessage("Tecil Tarihi Boş Bırakılamaz");
        }
    }
}

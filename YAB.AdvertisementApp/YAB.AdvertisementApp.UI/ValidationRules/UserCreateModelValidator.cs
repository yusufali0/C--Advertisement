using FluentValidation;
using System;
using YAB.AdvertisementApp.UI.Models;

namespace YAB.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        // [Obsolete]
        public UserCreateModelValidator()
        {
            //  CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola minimum 3 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parolalar eşleşmiyor");
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad boş olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş olamaz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı minimum 3 karakter olmalıdır");
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstname(x.Username, x.Firstname)).WithMessage("Kullanıcı adı adınızla aynı olamaz").When(x => x.Username != null && x.Firstname != null);

            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur");


        }

        private bool CanNotFirstname(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}

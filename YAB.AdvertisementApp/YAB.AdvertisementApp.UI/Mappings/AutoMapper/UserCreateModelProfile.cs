using AutoMapper;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.UI.Models;

namespace YAB.AdvertisementApp.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile:Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();
        }
    }
}

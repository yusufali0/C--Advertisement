﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Common;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService:IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto);

        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
    }
}

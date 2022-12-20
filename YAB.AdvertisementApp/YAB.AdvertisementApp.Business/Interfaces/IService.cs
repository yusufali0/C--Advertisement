using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.Common;
using YAB.AdvertisementApp.Dtos.Interfaces;
using YAB.AdvertisementApp.Dtos;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.Business.Interfaces
{
    public interface IService<CreateDto, UpdateDto, ListDto,T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);

        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);

        Task<IResponse<IDto>> GetByIdAsync<IDto>(int id);

        Task<IResponse> RemoveAsync(int id);

        Task<IResponse<List<ListDto>>> GetAllAsync();

    }
}

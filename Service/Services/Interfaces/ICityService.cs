﻿using Service.DTOs.Admin.Cities;

namespace Service.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllAsync();
        Task<CityDto> GetByIdAsync(int id);
        Task<CityDto> GetByNameAsync(string name);
        Task CreateAsync(CityCreateDto model);
        Task EditAsync(int? id, CityEditDto  model);
        Task DeleteAsync(int? id);
        Task<IEnumerable<CityDto>> FilterAsync(string name, string countryName);
    }
}

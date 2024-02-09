﻿using DesafioTecnico.Model.Dto;

namespace DesafioTecnico.Service.Interfaces
{
    public interface IApartmentService
    {
        Task<ApartmentDto> GetById(int id);
        Task<IEnumerable<ApartmentDto>> GetAll();
        Task<bool> Update(int id, ApartmentDto resident);
        Task<bool> Delete(int id);
        Task<ApartmentDto> Add(ApartmentDto resident);

    }
}
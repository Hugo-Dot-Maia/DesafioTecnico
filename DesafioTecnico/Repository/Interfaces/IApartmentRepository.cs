﻿using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Repository.Interfaces
{
    public interface IApartmentRepository : IBaseRepository
    {
        Task<Apartment> GetById(int id);
        Task<IEnumerable<Apartment>> GetAll();
    }
}

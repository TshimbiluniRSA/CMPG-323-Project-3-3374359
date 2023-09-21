﻿using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        Task<List<Order>> GetAll();
    }
}

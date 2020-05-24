using System;
using System.Collections.Generic;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Impl
{
    public class MachineRepository : ParentRepository<CoffeeShopAppContext, MachineDAO>
    {
        public MachineRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

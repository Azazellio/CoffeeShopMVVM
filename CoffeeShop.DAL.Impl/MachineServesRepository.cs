using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Impl
{
    class MachineServesRepository : ParentRepository<CoffeeShopAppContext, MachineServesDAO>
    {
        public MachineServesRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

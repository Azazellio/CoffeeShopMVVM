using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Impl
{
    class DrinkRepository : ParentRepository<CoffeeShopAppContext, DrinkDAO>
    {
        public DrinkRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

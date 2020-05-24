using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Impl
{
    class IngredientRepository : ParentRepository<CoffeeShopAppContext, IngredientDAO>
    {
        public IngredientRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

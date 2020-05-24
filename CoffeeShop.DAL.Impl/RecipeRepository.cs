using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;

namespace CoffeeShop.DAL.Impl
{
    class RecipeRepository : ParentRepository<CoffeeShopAppContext, RecipeDAO>
    {
        public RecipeRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

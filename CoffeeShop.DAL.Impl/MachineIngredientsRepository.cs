using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;
using CoffeeShop.DAO.Impl.DAO;
using CoffeeShop.DAO.Impl.DataContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Impl
{
    class MachineIngredientsRepository : ParentRepository<CoffeeShopAppContext, MachineIngredientDAO>
    {
        public MachineIngredientsRepository(CoffeeShopAppContext context) : base(context) { }
    }
}

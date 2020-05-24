using System;
using DAO.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Management.Automation;

namespace CoffeeShop.DAO.Impl.DAO
{
    public class MachineIngredientDAO : IEntity
    {
        [Key]
        public int Id { get; set; }

        [AllowNull]
        public int? MachineDAOId { get; set; } // Foreign Key to machine table
        [ForeignKey(nameof(MachineDAOId))]
        public MachineDAO MachineDAO { get; set; }

        [AllowNull]
        public int? IngredientDAOId { get; set; }   //foreign key to ingredient table
        [ForeignKey(nameof(IngredientDAOId))]
        public IngredientDAO IngredientDAO { get; set; }

        public int MaxCapacityWater { get; set; }
        public int MaxCapacityCoffee { get; set; }
        public int MaxCapacitySugar { get; set; }
        public int MaxCapacityMilk { get; set; }

        public int CurrentCapacityWater { get; set; }
        public int CurrentCapacityCoffee { get; set; }
        public int CurrentCapacitySugar { get; set; }
        public int CurrentCapacityMilk { get; set; }

    }
}

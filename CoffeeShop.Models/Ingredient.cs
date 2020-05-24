using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Ingredient
    {
        private static int _id = 0;
        public string name { get; private set; }
        public int id { get; private set; }
        public Ingredient(string name)
        {
            this.name = name;
            this.id = _id;
            _id++;
        }
    }
}

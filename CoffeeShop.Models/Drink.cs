using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Drink : ICloneable
    {
        private static int _id = 0;
        public int id { get; private set; }
        public string name { get; private set; }
        public DateTime time { get; private set; }
        public Drink(string name)
        {
            this.name = name;
            this.id = _id;
            _id++;
        }
        public object Clone()
        {
            var newDrink = new Drink(this.name);
            newDrink.time = DateTime.Now;
            return newDrink;
        }
    }
}

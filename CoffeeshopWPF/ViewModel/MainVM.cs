using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoffeeshopWPF.ViewModel
{
    class MainVM
    {
        private static Net net;
        public List<DateTime> list { get; set; }
        public Machine obj { get; set; }
        public RelayCommand AddCommand { get; private set; }

        public List<Machine> machines { get; set; }

        //private Guesser guesser;

        public void Add(object message)
        {
            MessageBox.Show("");
        }

        public MainVM()
        {
            net = new Net();
            //this.guesser = new Guesser(net);
            AddCommand = new RelayCommand(Add, AddCanuse);

            machines = new List<Machine>()
        {
            new Machine(100, 200, 300,400, net),
            new Machine(100, 200, 300,400, net),
            new Machine(100, 200, 300,400, net),
            new Machine(100, 200, 300,400, net),

        };
        }
        public bool AddCanuse(object message)
        {
            return true;
        }
    }
}
     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafea
{
    internal class Cafea
    {
        const int CoffeeShot = 50;
        const int MilkShot = 50; 
        enum CoffeeType {Cappucino,FlatWhite,BlackCoffee}

        
        private string name;
        private int milkQuantity;
        private int coffeeQuantity;
        private readonly string id; 
        private bool foam;
        private int quantity;
        private CoffeeType coffeeType;

        public CoffeeType()
        {
            
        }
        public CoffeeType(string id)
        {
            
        }

        public void preparareCapucino()
        {
            this.coffeeType = CoffeeType.Cappucino;
            this.milkQuantity = 100;
            this.coffeeQuantity = 100;
            this.foam = true;
            calculareCantitate();
        }
        public void preparareFlatWhite()
        {
            this.coffeeType = CoffeeType.FlatWhite;
            this.milkQuantity = 100;
            this.coffeeQuantity = adaugareShoturi(2);
            calculareCantitate();

        }
        public void preparareBlackCoffee()
        {
            this.coffeeType = CoffeeType.BlackCoffee;
            this.milkQuantity = 0;
        }
        private void calculareCantitate()
        {
            this.quantity = this.milkQuantity + this.coffeeQuantity; 
        }
        private int adaugareShoturi(int shoturi)
        {
            return shoturi * CoffeeShot;
        }

        public override string ToString()
        {
            return this.coffeeType.ToString();
        }


    }
}

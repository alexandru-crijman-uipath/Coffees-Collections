using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafea
{
    internal class Rasnita
    {
        private static string CoffeeOrigin;
        private readonly string name;


        public static Cafea preparareCappucino()
        {
            Cafea cafea = new Cafea(CoffeeOrigin);
            cafea.preparareCapucino();
            return cafea;
            Cafea cafea2;
            

        }


       
    }
}

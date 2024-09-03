using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int discount) : base(discount)
        {
        }

        public int mlMilk()
        {
            return 200;        
        }

        public override int Price()
        {
            if (Discount > 5)
            {
                throw new Exception("Discount too high");
            }
            return 40 - Discount;
        }
        public override string Strength()
        {
            return "Weak";
        }
    }
}

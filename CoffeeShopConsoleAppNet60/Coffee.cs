using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }

        protected Coffee(int discount)
        {
            Discount = discount;
        }

        public virtual int Price()
        {
            if (Discount > 5)
            {
                throw new Exception("Discount too high");
            }

            return 20-Discount;
        }

        public abstract string Strength();
    }
}

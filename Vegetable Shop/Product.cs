using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class Product
    {
        public int BasePrice { get; private set; }
        public int Price { get; set; }
        public Product(int BasePrice)
        {
            this.BasePrice = BasePrice;
            this.Price = BasePrice;
        }

        public virtual string Details_price => $"Price: {Price}";
    }
}

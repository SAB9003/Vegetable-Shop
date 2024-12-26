using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class Potato : Product
    {
        public int Count { get; set; }
        public Potato(int BasePrice, int Count) : base(BasePrice)
        {
            this.Count = Count;
            Price = BasePrice * Count;
        }
        public override string Details_price => $"Product: Potato, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }
}

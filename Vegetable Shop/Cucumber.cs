using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class Cucumber : Product
    {
        public int Count { get; set; }
        public Cucumber(int BasePrice, int Count) : base(BasePrice)
        {
            this.Count = Count;
            Price = BasePrice * Count;
        }
        public override string Details_price => $"Product: Cucumber, Price: {BasePrice}, Count: {Count}, Total price: {Price}";
    }
}

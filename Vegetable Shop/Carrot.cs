using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class Carrot : Product
    {
        public Carrot(int BasePrice) : base(BasePrice) { }
        public override string Details_price => $"Product: Carrot, {base.Details_price}";
    }
}

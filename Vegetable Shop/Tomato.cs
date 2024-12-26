using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class Tomato : Product
    {
        public Tomato(int BasePrice) : base(BasePrice) { }
        public override string Details_price => $"Product: Tomato, {base.Details_price}";
    }
}

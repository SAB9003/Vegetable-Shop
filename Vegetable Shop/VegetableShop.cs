using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Shop
{
    public class VegetableShop
    {
        List<Product> products = new List<Product>();
        public void AddProducts(List<Product> new_products)
        {
            products.AddRange(new_products);
        }
        public void PrintProductsInfo()
        {
            int sum_prise = 0;
            foreach (Product product in products)
            {
                Console.WriteLine(product.Details_price);
                sum_prise += product.Price;
            }
            Console.WriteLine($"Total products price: {sum_prise}");
        }
    }
}

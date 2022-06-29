using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9
{
    internal class Price
    {
        private Dictionary<string, double> productPrice;
        public Price()
        {
            productPrice = new();
        }
        public Price(Dictionary<string, double> productPrice) : this()
        {
            productPrice = productPrice;
        }
        public bool TryGetProductPrice(string productName, out double price)
        {
            if (!productPrice.TryGetValue(productName, out double result))
            {
                price = default;
                return false;
            }
            price = result;
            return true;
        }
        public void AddPrice(string productName, double price)
        {
            productPrice[productName] = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var (key, value) in this.productPrice)
            {
                sb.Append(key + " " + value + "\n");
            }
            return sb.ToString();
        }
    }
}

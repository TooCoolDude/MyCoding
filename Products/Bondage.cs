using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop.Products
{
    class Bondage : Product
    {
        public int Size { get; set; }
        public Bondage(string name, double price, string manufacturer, int size) 
        {
            Size = size;
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.Name[0] == 'A')
                return Price/2;
            return Price;
        }
    }
}

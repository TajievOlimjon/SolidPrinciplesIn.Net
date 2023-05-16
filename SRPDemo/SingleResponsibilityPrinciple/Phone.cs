using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class Phone
    {
        public string Model { get; }
        public int Price { get; }
        public Phone(string model,int price)
        {
            Model = model;
            Price = price;
        }
    }
}

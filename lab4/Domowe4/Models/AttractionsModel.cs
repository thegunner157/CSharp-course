using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domowe4.Models
{
    public class AttractionsModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Time { get; set; }
        public string Photo { get; set; }
        public AttractionsModel(int price, string name, string photo, string time)
        {
            Price = price;
            Name = name;
            Photo = photo;
            Time = time;
        }

    }
}

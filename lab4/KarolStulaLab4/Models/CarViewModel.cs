using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarolStulaLab4.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Marka
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Zdjecie
        /// </summary>
        public string Photo { get; set; }
        public CarViewModel(string model, string manufacturer, decimal price, string photo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Photo = photo;
        }
    }
}

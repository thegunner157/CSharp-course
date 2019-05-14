using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domowe4.Models
{
    public class MonumentsModel
    {
        /// <summary>
        /// age
        /// </summary>
        public int Age{ get; set; }
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// photo
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Recognizability
        /// </summary>
        public string Recognizability { get; set; }
        public MonumentsModel(int age, string name, string photo, string recognize)
        {
            Age = age;
            Name = name;
            Photo = photo;
            Recognizability = recognize;
        }



    }
}

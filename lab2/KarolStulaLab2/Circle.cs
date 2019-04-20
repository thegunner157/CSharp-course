using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarolStulaLab2
{
    public class Circle : Shape
    {
        public Circle(float size = 1)
        {
            this.size = size;
        }
        /// <summary>
        /// oblicza  i zwraca pole koła
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            float area = 3.14F * size * size;
            return area;
        }
        /// <summary>
        /// Nadpisanie metody ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Koło";
        }
        /// <summary>
        /// zwraca obwod koła
        /// </summary>
        /// <returns></returns>
        public override string Perimeter()
        {
            base.Perimeter();
            float perimeter = 3.14F * 2 * size;
            return perimeter.ToString();
        }
    }
}

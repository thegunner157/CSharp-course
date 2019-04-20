using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolStulaLab2
{
    /// <summary>
    /// klasa abstrakcyjna
    /// </summary>
    public abstract class Shape
    {
        //pole zawierajace rozmiar
        protected float size;
        //abstrakcyjna metoda
        public abstract float Area();

        // metoda wirtualna, zwraca obwod
        public virtual string Perimeter()
        {
            MessageBox.Show("Tutaj klasa bazowa");
            return "Bazowa";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarolStulaLab2
{
    class Square : Shape, IReseizable
    {
        /// <summary>
        /// konstruktor parametryczny
        /// </summary>
        /// <param name="size"></param>
        public Square(float size=1)
        {
            this.size = size;
           
        }
        /// <summary>
        /// Wyswietlanie formy dla wprowadzenia nowej dlugosci
        /// </summary>
        public void ChangeSize()
        {
            string input = Prompt.ShowDialog("Zmien dlugosc boku", "Podaj nowa dlugosc boku");
            size = float.Parse(input);
        }
        /// <summary>
        /// metoda obliczajaca pole kwadratu
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return size * size;
        }
        /// <summary>
        /// Nadpisanie metody ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Kwadrat";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domowe2
{
    public class Dave : Character, Igetitems
    {
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="money"></param>
        /// <param name="Accuracy"></param>
        /// <param name="Approximateshoot"></param>
        /// <param name="experience"></param>
        public Dave(int money = 0, int which = 2, int Accuracy = 0, int Approximateshoot = 0, int experience = 0, string name = "Dave")
        {
            this.whichPlayer = which;
            this.money = money;
            this.experience = experience;
            this.approximationShoot = Approximateshoot;
            this.slowerPointer = Accuracy;
            this.name = name;
        }
        /// <summary>
        /// Functions to access fields
        /// </summary>
        /// <returns></returns>
        public override string getName()
        {
            return name;
        }
        public override int getwhichPlayer()
        {
            return whichPlayer;
        }
        public int getMoney()
        {
            return money;
        }
        public int getExperience()
        {
            return experience;
        }
        public override int getapproximationShoot()
        {
            return approximationShoot;
        }
        public override int getslowerPointer()
        {
            return slowerPointer;
        }
        /// <summary>
        /// Nadpisanie metody ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
                return "Dave";
            }
        
    }
}

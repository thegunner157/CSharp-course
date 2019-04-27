using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domowe2
{
    public abstract class Character
    {
        /// <summary>
        /// variables and methods
        /// </summary>
        public int whichPlayer;
        public int money;
        public int experience;
        public int approximationShoot;
        public int slowerPointer;
        public string name;
        public abstract string getName();
        public abstract int getwhichPlayer();
        public abstract int getapproximationShoot();
        public abstract int getslowerPointer();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public abstract class Bil
    {
        public int pris { get; private set; }

        /// <summary>
        /// ingen default ctor længere
        /// </summary>
        /// <param name="pris"></param>

        public Bil(int pris)
        {
            this.pris = pris;
        }

        /// <summary>
        /// Afgift må gerne blive overskrevet, behøves ikke men kan godt, deraf virtual navnet
        /// </summary>
        /// <returns></returns>

        //public virtual int afgift()
        //{
        //    return 1000; 
        //}

        public abstract int Afgift();
    }
}

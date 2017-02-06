using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    class DieselBil : Bil
    {
        public bool Partikelfilter { get; private set; }

        /// <summary>
        /// this peger på Partikelfilter propertien i klassen.
        /// Hold det med for overskueligheden for andre også.
        /// </summary>
        /// <param name="pris"></param>
        /// <param name="partikelfilter"></param>

        public DieselBil(int pris, bool partikelfilter) : base(pris)
        {
            this.Partikelfilter = partikelfilter;
        }

        /// <summary>
        /// hvis dielselbil kun kaldes med en variable i kontruktoren 
        /// så alle bil objekter herfra med partikelfilter altså true
        /// </summary>
        /// <param name="pris"></param>

        public DieselBil(int pris):this(pris,true)
        {

        }

        //public override int afgift()
        //{
        //    return base.afgift() + 200;
        //}

        public override int Afgift()
        {
            return 1200;
        }

    }
}

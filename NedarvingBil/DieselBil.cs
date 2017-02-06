using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public class DieselBil : Bil
    {
        public bool Partikelfilter { get; private set; }

        /// <summary>
        /// this peger på Partikelfilter propertien i klassen.
        /// Hold det med for overskueligheden for andre også.
        /// </summary>

        public DieselBil(string mærke, int bilPrisExAfgift, int købsÅr, int kmPrLiter, bool partikelfilter) : 
            base(mærke, bilPrisExAfgift, købsÅr, kmPrLiter)
        {
            this.Partikelfilter = partikelfilter;
        }

        public DieselBil(string mærke, int bilPrisExAfgift, int købsÅr, int kmPrLiter)
            :this(mærke, bilPrisExAfgift, købsÅr, kmPrLiter, true)
        {

        }

        /// <summary>
        /// hvis dielselbil kun kaldes med en variable i kontruktoren 
        /// så alle bil objekter herfra med partikelfilter altså true
        /// </summary>
        /// <param name="pris"></param>

    

        public override int HalvÅrligEjerafgift()
        {
            return base.HalvÅrligEjerafgift() + 500;
        }

        //public override int Afgift()
        //{
        //    return 1200;
        //}

        public override string ToString()
        {
            return "Mærket på bilen er: "+ Mærke + "." +" Bilen koster uden afgift: " +
                BilPrisExAfgift + "." + " Købsåret for bilen er: " + KøbsÅr + "." + " Bilen kører " 
                + KmPrLiter + " km per liter. " + " Bilen har partikelfilter: " + Partikelfilter + ".";
        }

        public int GetHalvÅrigeAfgift()
        {
            return HalvÅrligEjerafgift();
        }

    }
}

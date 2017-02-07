using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public class ElBil:Bil
    {

        public int BatteriKapacitet { get; set; }

        public int KmPrKw { get; set; }

        public ElBil(string mærke, int bilPrisExAfgift, int købsÅr, string registreringsNr, int kmPrKW, int batteriKapacitet) 
            : base(mærke, bilPrisExAfgift, købsÅr, registreringsNr)
        {
            this.KmPrKw = kmPrKW;
            this.BatteriKapacitet = batteriKapacitet;
        }


        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override int GetRegistreringsAfgift()
        {
            return base.GetRegistreringsAfgift() * 20/100;

        }

        public override int GetRækkeVidde()
        {
            return BatteriKapacitet * KmPrKw;
        }

        public override string ToString()
        {
            return "Mærket på bilen er: " + Mærke + "." + " Bilen koster uden afgift: " +
                BilPrisExAfgift + "." + " Købsåret for bilen er: " + KøbsÅr + "." 
                + "Kilometer per kilowat kan indeholde: " + KmPrKw + "." 
                + "BatteriKapaciteten er: " + BatteriKapacitet + ".";
        }

    }
}

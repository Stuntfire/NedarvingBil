using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public sealed class BenzinBil : Bil
    {

        public int Tank { get; set; }

        public int KmPrLiter { get; set; }

        public BenzinBil(string mærke, int bilPrisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, int tank) : base(mærke, bilPrisExAfgift, købsÅr, registreringsNr)
        {
            this.Tank = tank;
            this.KmPrLiter = kmPrLiter;
        }

        public override int HalvÅrligEjerafgift()
        {
            int halveÅrsEjerAfgiftBb = 0;

            if (KmPrLiter < 20)
            {
                halveÅrsEjerAfgiftBb = 1200;
            }

            if ((KmPrLiter >= 20 ) && (KmPrLiter <= 28))
            {
                halveÅrsEjerAfgiftBb = 600;
            }

            if (KmPrLiter > 28 ) 
            {
                halveÅrsEjerAfgiftBb = 320;
            }
            return halveÅrsEjerAfgiftBb;
        }

        public override int GetRækkeVidde()
        {
            return Tank * KmPrLiter;
        }

        public override string HvilkenBilErJeg()
        {
            return "Jeg er en class BenzinBil";
        }

        public override string ToString()
        {
            return "Mærket på bilen er: " + Mærke + "." + " Bilen koster uden afgift: " +
                BilPrisExAfgift + "." + " Købsåret for bilen er: " + KøbsÅr + "." + " Bilen kører "
                + KmPrLiter + " km per liter." + "Tanken kan indeholde: " + Tank + ".";
        }
    }
}

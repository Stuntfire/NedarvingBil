using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public class BenzinBil : Bil
    {
        public int Octan { get; set; }

        public BenzinBil(string mærke, int bilPrisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter) : base(mærke, bilPrisExAfgift, købsÅr, registreringsNr, kmPrLiter)
        {
        }

        public override int HalvÅrligEjerafgift()
        {
      
            int halveÅrsEjerAfgiftBb = 0;

            if (KmPrLiter < 20)
            {
                halveÅrsEjerAfgiftBb = 1200;
            }

            if ((KmPrLiter == 20 ) && (KmPrLiter <= 28))
            {
                halveÅrsEjerAfgiftBb = 600;
            }

            if (KmPrLiter > 28 ) 
            {
                halveÅrsEjerAfgiftBb = 320;
            }
            return halveÅrsEjerAfgiftBb;
        }

        //public override string HvilkenBilErJeg()
        //{
        //    return "Jeg er en class benzinbil";
        //}


        //public BenzinBil(int pris) : base(pris)
        //{
        //}

        //public override int Afgift()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public abstract class Bil
    {
        public int BilPrisExAfgift { get; private set; }

        public int KøbsÅr { get; private set; }

        public string Mærke { get; set; }

        public string RegistreringsNr { get; set; }

        public int KmPrLiter { get; set; }

        public int registreringsAfgift { get;  set; }

        /// <summary>
        /// ingen default ctor længere
        /// </summary>
        /// <param name="pris"></param>

        //public Bil(int pris)
        //{
        //    this.pris = pris;
        //}

        /// <summary>
        /// Afgift må gerne blive overskrevet, behøves ikke men kan godt, deraf virtual navnet
        /// </summary>
        /// <returns></returns>

        //public virtual int afgift()
        //{
        //    return 1000; 
        //}

        public Bil(string mærke, int bilPrisExAfgift, int købsÅr, int kmPrLiter)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilPrisExAfgift;
            this.KøbsÅr = købsÅr;
            this.KmPrLiter = kmPrLiter;
        }

        public virtual int RegistreringsAfgift()
        {
            registreringsAfgift = 0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    registreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 80500)
                {
                    registreringsAfgift = BilPrisExAfgift * 105/100;
                    registreringsAfgift = registreringsAfgift + (BilPrisExAfgift - 80500) * 180/100;
                }
            }
            else 
            {
                if (BilPrisExAfgift <= 81700)
                {
                    registreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 81700)
                {
                    registreringsAfgift = BilPrisExAfgift * 105 / 100;
                    registreringsAfgift = registreringsAfgift + (BilPrisExAfgift - 81700) * 180 / 100;
                }
            }

            return registreringsAfgift;
        }


        public int TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }
    }
}

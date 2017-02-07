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

        private int _registreringsAfgift;

        public int RegistreringsAfgift
        {
            get { return _registreringsAfgift; }
            set { _registreringsAfgift = value; }
        }

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

        public Bil(string mærke, int bilPrisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilPrisExAfgift;
            this.KøbsÅr = købsÅr;
            this.RegistreringsNr = registreringsNr;
            this.KmPrLiter = kmPrLiter;
        }

        public virtual int GetRegistreringsAfgift()
        {
            _registreringsAfgift = 0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    _registreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 80500)
                {
                    _registreringsAfgift = BilPrisExAfgift * 105/100;
                    _registreringsAfgift = _registreringsAfgift + (BilPrisExAfgift - 80500) * 180/100;
                }
            }
            else 
            {
                if (BilPrisExAfgift <= 81700)
                {
                    _registreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 81700)
                {
                    _registreringsAfgift = BilPrisExAfgift * 105 / 100;
                    _registreringsAfgift = _registreringsAfgift + (BilPrisExAfgift - 81700) * 180 / 100;
                }
            }

            return _registreringsAfgift;
        }


        public int TotalPris()
        {
            return BilPrisExAfgift + GetRegistreringsAfgift();
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public class BenzinBil : Bil
    {
        public BenzinBil(int pris) : base(pris)
        {
        }

        public override int Afgift()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom
{
    public struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni)
        {
            realniDio = realni;
            imaginarniDio = imaginarni;
        }
        static public KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new KompleksniBroj(br1.realniDio + br2.realniDio, br1.imaginarniDio + br2.imaginarniDio);
        }

        public double realniDio;
        public double imaginarniDio;


    }
}

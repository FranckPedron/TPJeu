using System;
using System.Collections.Generic;
using System.Text;

namespace TPJeu
{
    class De
    {
        public De()
        {
        random = new Random();
        }

        public int LanceLeDe(){
        return random.Next(1,7) ;
        }
    }
}

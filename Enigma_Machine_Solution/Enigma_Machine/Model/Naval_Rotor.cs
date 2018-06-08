using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine.Model
{
    internal class Naval_Rotor : Rotor
    {
        private char turnOver2;

        public Naval_Rotor(string w, char to, char to2, string n) : base(w, to, n)
        {
            turnOver2 = to2;
        }

        public override bool isInTurnOver()
        {
            if (turnOver == OuterChar || turnOver2 == OuterChar)
                return true;
            else
                return false;
        }
    }
}

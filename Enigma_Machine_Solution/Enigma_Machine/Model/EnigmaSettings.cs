using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine.Model
{
    //This class holds the settings for the Enigma machine, such as rings etc.
    public class EnigmaSettings
    {
        public char[] rings { get; set; }
        public char[] grund { get; set; }
        public string order { get; set; }
        public char reflector { get; set; }
        public List<string> plugs = new List<string>();

        public EnigmaSettings()
        {
            setDefault();
        }

        public void setDefault()
        {
            rings = new char[] { 'A', 'A', 'A' };
            grund = new char[] { 'A', 'A', 'A' };

            order = "I-II-III";

            reflector = 'B';

            plugs.Clear();
        }

        public void storeGround(int f, int m, int s)
        {
            grund[0] = (Char)(s + 64);
            grund[1] = (Char)(m + 64);
            grund[2] = (Char)(f + 64);
        }

        public void storeRings(int f, int m, int s)
        {
            rings[0] = (Char)(s + 64);
            rings[1] = (Char)(m + 64);
            rings[2] = (Char)(f + 64);
        }
    }
}

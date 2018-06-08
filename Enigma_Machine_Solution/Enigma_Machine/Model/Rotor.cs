using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine.Model
{
    //This class represents the information one rotor holds.
    class Rotor 
    {
        protected const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //We display a letter to the outside and keep its number secret.
        private int outerPosition;
        public char OuterChar { get; set; }

        //All rotors have a set wiring.
        private string wiring;

        //All rotors have a set letter where they turn the next rotor.
        protected char turnOver;

        //The rotors have a name.
        public string name { get; }

        //We also need to keep track of the ring setting and 
        //how the inner wiring is set up.
        public char ring { get; set; }

        public int[] map { get; }
        public int[] revMap { get; }

        //Constructor
        public Rotor(string w, char to, string n)
        {
            // Where the rotor turns.
            turnOver = to;

            // We'll be tracking the outer position one behind the actual number
            outerPosition = 0;

            ring = 'A'; // Per default the ring inside is at A.
            name = n; // Name the rotor.

            map = new int[26];
            revMap = new int[26];

            setWiring(w);
        }

        private void setWiring(string wiring)
        {
            // Set the rotors wires.
            this.wiring = wiring;

            OuterChar = wiring.ToCharArray()[outerPosition];

            // Filling the mapping arrays
            for (int i = 0; i < 26; i++)
            {
                // Take the wired characters and remake them into numbers.
                int match = ((int)wiring.ToCharArray()[i]) - 65;
                
                // How the rotor will transform a character. revMap is for the
                // "return trip".
                map[i] = (26 + match - i) % 26;
                revMap[match] = (26 + i - match) % 26;
            }
        }

        //This function determines what position the rotor is when E/D starts.
        public void setOuterPosition(int i)
        {
            outerPosition = i;
            OuterChar = alphabet.ToCharArray()[outerPosition];
        }

        //Needs to know in which position the rotor is.
        public int getOuterPosition()
        {
            return outerPosition;
        }

        public void setOuterChar(char c)
        {
            OuterChar = c;
            outerPosition = alphabet.IndexOf(OuterChar);
        }

        //Every 26 steps the fast rotor causes the middle rotor to rotate.
        public void step()
        {
            outerPosition = (outerPosition + 1) % 26;
            OuterChar = alphabet.ToCharArray()[outerPosition];
        }

        //This function checks and reports if the next rotor should rotate.
        public virtual bool isInTurnOver()
        {
            return OuterChar == turnOver;
        }
    }
}

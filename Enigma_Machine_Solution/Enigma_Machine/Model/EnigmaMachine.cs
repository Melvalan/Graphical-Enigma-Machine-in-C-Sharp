using Enigma_Machine.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine.Model
{
    public class EnigmaMachine
    {
        /*
         *  The Enigma machine requires the following:
         *  Plugboard,
         *  Rotors,
         *  Reflectors,
         *  Entrydrum
         */

        //Create the plugboard, which will compare two letters.
        private Dictionary<Char, Char> plugBoard;

        //We need to know our three rotors and the reflector.
        private Rotor[] rotors;
        private Rotor reflector;

        protected const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        protected const string I =    "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        protected const string II =   "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        protected const string III =  "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        protected const string IV =   "ESOVPZJAYQUIRHXLNFTGKDCMWB";
        protected const string V =    "VZBRGITYUPSDNHLXAWMJQOFECK";
        protected const string VI =   "JPGVOUMFYQBENHZRDKASXLICTW";
        protected const string VII =  "NZJHGRCXMYSWBOUFAIVLPEKQDT";
        protected const string VIII = "FKQHTLXOCBJSPDZRAMEWNIUYGV";

        protected const string A = "EJMZALYXVBWFCRQUONTSPIKHGD";
        protected const string B = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
        protected const string C = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

        //Constructor
        public EnigmaMachine(string fastR, string mediumR, string slowR, string refl, EnigmaSettings e)
        {
            string[] rotorsChoice = { slowR, mediumR, fastR, refl };

            rotors = new Rotor[3];

            //Initialize the plugboard.
            plugBoard = new Dictionary<char, char>();

            // The notch, as well as alphabet is fixed.
            // We shall now create our rotors, to do so, requires we know the 
            // Rotors which have been chosen.

            e.order = "";

            for (int i = 0; i < 4; i++)
            {
                switch (rotorsChoice[i])
                {
                    case "I":
                        rotors[i] = new Rotor(I, 'Q', "I");
                        e.order += (e.order.Equals(""))?"I":"-I";
                        break;
                    case "II":
                        rotors[i] = new Rotor(II, 'E', "II");
                        e.order += (e.order.Equals("")) ? "II" : "-II"; ;
                        break;
                    case "III":
                        rotors[i] = new Rotor(III, 'V', "III");
                        e.order += (e.order.Equals("")) ? "III" : "-III"; ;
                        break;
                    case "IV":
                        rotors[i] = new Rotor(IV, 'J', "IV");
                        e.order += (e.order.Equals("")) ? "IV" : "-IV"; ;
                        break;
                    case "V":
                        rotors[i] = new Rotor(V, 'Z', "V");
                        e.order += (e.order.Equals("")) ? "V" : "-V"; ;
                        break;
                    case "VI":
                        rotors[i] = new Naval_Rotor(VI, 'M', 'Z', "VI");
                        e.order += (e.order.Equals("")) ? "VI" : "-VI"; ;
                        break;
                    case "VII":
                        rotors[i] = new Naval_Rotor(VII, 'M', 'Z', "VII");
                        e.order += (e.order.Equals("")) ? "VII" : "-VII"; ;
                        break;
                    case "VIII":
                        rotors[i] = new Naval_Rotor(VIII, 'M', 'Z', "VIII");
                        e.order += (e.order.Equals("")) ? "VIII" : "-VIII"; ;
                        break;
                    case "A":
                        reflector = new Rotor(A, ' ', "");
                        e.reflector = 'A';
                        break;
                    case "B":
                        reflector = new Rotor(B, ' ', "");
                        e.reflector = 'B';
                        break;
                    case "C":
                        reflector = new Rotor(C, ' ', "");
                        e.reflector = 'C';
                        break;
                }
            }


        }

        public void setSettings(char[] rings, char[] grund)
        {
            if (rings.Length != rotors.Length || grund.Length != rotors.Length)
            {
                throw new ArgumentException("Invalid argument lengths");
            }

            for (int i = 0; i < rotors.Length; i++)
            {
                rotors[i].ring = Char.ToUpper(rings[i]);
                rotors[i].setOuterChar(Char.ToUpper(grund[i]));
            }
        }
    
        public string runEnigma(string msg)
        {
            StringBuilder encryptedMessage = new StringBuilder();

            msg = msg.ToUpper();

            foreach (char c in msg)
            {
                encryptedMessage.Append(encryptChar(c));
            }

            return encryptedMessage.ToString();
        }

        public void setSteckers(string[] s)
        {
            foreach (string plug in s)
            {
                char[] p = plug.ToCharArray();
                addPlug(p[0], p[1]);
            }
        }

        //Encrypts or decrypts the one single character sent in here.
        private char encryptChar(char c)
        {
            //Rotate first!
            rotateRotors(rotors);

            // Firstly the plugboard!
            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }

            //Scramble with rotors.
            //All three rotors!
            c = rotorMap(c, false);

            // Remember to reflect before sending back!
            c = reflectorMap(c);

            // All rotors, other way, this time!
            c = rotorMap(c, true);

            //And agains the plugboard!
            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }

            //Character now encrypted
            return c;
        }

        //Here we add the steckers!
        private void addPlug(char c, char cc)
        {
            if(Char.IsLetter(c) && Char.IsLetter(cc))
            {
                c = Char.ToUpper(c);
                cc = Char.ToUpper(cc);

                if (c != cc && !plugBoard.ContainsKey(c))
                {
                    plugBoard.Add(c, cc);
                    plugBoard.Add(cc, c);
                    Manager.storePlugs(c, cc);
                }
                else
                    throw new ArgumentException("Invalid Character!");
            }
        }

        //We get the three chosen rotors and rotate then as they are supposed to be rotated.
        private void rotateRotors(Rotor[] r)
        {
            if(r.Length == 3)
            {
                //Check if a rotor is about to cause the next rotor to step.
                //Remember, position 0 is the slow rotor, number 2 is the fast rotor.
                if (r[1].isInTurnOver())
                {
                    //If fast rotor is about to turn, turn all rotors.
                    r[0].step();
                    r[1].step();

                //Here we check the fast rotor.
                }else if (r[2].isInTurnOver())
                {
                    //If the fast rotor is in correct position, let's turn the next one.
                    r[1].step();
                }

                //Always step the fast rotor.
                r[2].step();
            }
        }

        // We shall now scramble the character! by use of all rotors and reflector.
        // Reverse here keeps track of if we're moving towards or away from reflector.
        private char rotorMap(char c, bool reverse)
        {
            //Turn the character into numbers.
            int cPos = (int)c - 65;

            if (!reverse)
            {
                for(int i = rotors.Length - 1; i >= 0; i--)
                {
                    cPos = rotorValue(rotors[i], cPos, reverse);
                }
            }
            else
            {
                for(int i = 0; i < rotors.Length; i++)
                {
                    cPos = rotorValue(rotors[i], cPos, reverse);
                }
            }

            return alphabet.ToCharArray()[cPos];
        }

        private int rotorValue(Rotor r, int cPos, bool reverse)
        {
            int rPos = (int)r.ring - 65;
            int d;

            if (!reverse)
            {
                // Use this map when we're headed towards reflector.
                d = r.map[(26 + cPos + r.getOuterPosition() - rPos) % 26];
            }
            else
            {
                //If we're returning from reflector use the other map.
                d = r.revMap[(26 + cPos + r.getOuterPosition() - rPos) % 26];
            }

            return (cPos + d) % 26;
        }

        // We apply reflector after the three rotors.
        private char reflectorMap(char c)
        {
            int cPos = (int)c - 65;
            cPos = (cPos + reflector.map[cPos]) % 26;

            return alphabet.ToCharArray()[cPos];
        }


    }
}

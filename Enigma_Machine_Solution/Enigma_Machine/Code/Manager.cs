using Enigma_Machine.Forms;
using Enigma_Machine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Machine.Code
{
    class Manager
    {
        static EnigmaMachine Enigma = null;
        static EnigmaSettings Enigma_Settings;
        static Enigma_Window EnigmaWindow;

        public Manager()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EnigmaWindow = new Enigma_Window();
            Application.Run(EnigmaWindow);
        }

        public static void Encrypt_Decrypt(string fRo, string mRo, string sRo, string Ref, string[] steckers, int fRi, int mRi, int sRi, int fGr, int mGr, int sGr, string text)
        {
            Enigma_Settings = new EnigmaSettings();
            Enigma = new EnigmaMachine(fRo, mRo, sRo, Ref, Enigma_Settings);

            text = text.Replace(" ", "").ToUpper();

            if(!Regex.IsMatch(text, @"^[a-zA-Z ]+$"))
            {
                EnigmaWindow.setText("You can only enter letters, no numbers, not special tokens. Try again.");
                return;
            }

            if (!steckers[0].Equals(""))
            {
                Enigma.setSteckers(steckers);
            }

            Enigma_Settings.storeRings(fRi, mRi, sRi);
            Enigma_Settings.storeGround(fGr, mGr, sGr);

            Enigma.setSettings(Enigma_Settings.rings, Enigma_Settings.grund);

            printResult(text);

            /*Debugging, make sure that the ring setting is taken correctly.
            Enigma_Settings.rings[0] = (Char)(sRi + 64);

            EnigmaWindow.setChar(Enigma_Settings.rings[0]);*/
        }   

        private static void printResult(string t)
        {
            string steckers = "";
            string c = "";

            for(int i = 0; i < Enigma_Settings.plugs.Count; i++)
            {
                steckers += Enigma_Settings.plugs.ElementAt(i) + " ";
            }

            c = Enigma.runEnigma(t);

            string message = "Enigma Machine:\n----------------------------------" +
                "\nRotor Order: " + Enigma_Settings.order +
                "\nReflector: " + Enigma_Settings.reflector.ToString() +
                "\nRing Settings: " + Enigma_Settings.rings[0].ToString() + Enigma_Settings.rings[1].ToString() + Enigma_Settings.rings[2].ToString() +
                "\nGround Settings: " + Enigma_Settings.grund[0].ToString() + Enigma_Settings.grund[1].ToString() + Enigma_Settings.grund[2].ToString() +
                "\nSteckers: " + steckers +
                "\n\nPlain Text: " + t +
                "\nCryptotext: " + c;

            EnigmaWindow.setText(message);
        }

        public static void storePlugs(char c, char cc)
        {
            Enigma_Settings.plugs.Add(c.ToString() + cc.ToString());
        }
    }
}

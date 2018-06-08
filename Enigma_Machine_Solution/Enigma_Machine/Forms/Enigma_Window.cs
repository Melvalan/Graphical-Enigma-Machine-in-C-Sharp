using Enigma_Machine.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Machine.Forms
{
    public partial class Enigma_Window : Form
    {
        public Enigma_Window()
        {
            InitializeComponent();
        }

        private void ED_btn_Click(object sender, EventArgs e)
        {
            string fastRotor, mediumRotor, slowRotor, reflector, text;
            string[] steckers;

            int  fastRing, mediumRing, slowRing, fastGround, mediumGround, slowGround;

            fastRotor = fastRotor_box.Text;
            mediumRotor = mediumRotor_box.Text;
            slowRotor = slowRotor_box.Text;

            reflector = reflector_box.Text;

            steckers = stecker_box.Replace(" ", "").Text.Split(',');

            fastRing = (int)fastRing_box.Value;
            mediumRing = (int)mediumRing_box.Value;
            slowRing = (int)slowRing_box.Value;

            fastGround = (int)fastGround_box.Value;
            mediumGround = (int)mediumGround_box.Value;
            slowGround = (int)slowGround_box.Value;

            text = EDText_box.Text.Trim();

            Manager.Encrypt_Decrypt(fastRotor, mediumRotor, slowRotor, reflector, steckers, fastRing, mediumRing, slowRing, fastGround, mediumGround, slowGround, text);
        }

        public void setText(string c)
        {
            richTextBox1.Text = c;
        }

        public void setChar(char c)
        {
            richTextBox1.Text = c.ToString();
        }
    }
}

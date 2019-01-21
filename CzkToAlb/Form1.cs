using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzkToAlb
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> CzechDictionary()
        {
            Dictionary<string, string> czechwords = new Dictionary<string, string>();

            czechwords.Add("JE", "ě");
            czechwords.Add("A", "a");
            czechwords.Add("B", "b");
            czechwords.Add("C", "c");
            czechwords.Add("Ç", "Č ");
            czechwords.Add("D", "d");
            czechwords.Add("DH", "ð");
            czechwords.Add("E", "é");
            czechwords.Add("Ë", "ə");
            czechwords.Add("F", "f");
            czechwords.Add("G", "g");
            czechwords.Add("Gj", "Ď");
            czechwords.Add("H", "h");
            czechwords.Add("I", "i");
            czechwords.Add("J", "j");
            czechwords.Add("K", "k");
            czechwords.Add("L", "l");
            czechwords.Add("LL", "ɫ");
            czechwords.Add("M", "m");
            czechwords.Add("N", "n");
            czechwords.Add("Nj", "ň");
            czechwords.Add("O", "o");
            czechwords.Add("P", "p");
            czechwords.Add("Q", "c");
            czechwords.Add("R", "r");
            czechwords.Add("RR", "r");
            czechwords.Add("S", "s");
            czechwords.Add("Sh", "š");
            czechwords.Add("T", "t");
            czechwords.Add("TH", "θ");
            czechwords.Add("U", "u");
            czechwords.Add("V", "v");
            czechwords.Add("X", "dz");
            czechwords.Add("Xh", "dž");
            czechwords.Add("Y", "y");
            czechwords.Add("Z", "z");
            czechwords.Add("Zh", "ž");



            return czechwords;
        }
        public static Dictionary<string, string> AlbanianDictionary()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            // Double letters
            words.Add("SH", "ʃ");
            words.Add("RR", "r");
            words.Add("NJ", "ɲ");
            words.Add("DH", "ð");
            words.Add("GJ", "ɟ");
            words.Add("LL", "ɫ");
            words.Add("ZH", "ʒ");
            words.Add("TH", "θ");
            words.Add("XH", "d͡ʒ");
            //single letters
            words.Add("A", "ä");
            words.Add("B", "b");
            words.Add("C", "t͡s");
            words.Add("Ç", "t͡ʃ");
            words.Add("D", "d");
            words.Add("E", "ɛ");
            words.Add("Ë", "ə");
            words.Add("F", "f");
            words.Add("G", "ɡ");
            words.Add("H", "h");
            words.Add("I", "i");
            words.Add("J", "j");
            words.Add("K", "k");
            words.Add("L", "l");
            words.Add("M", "m");
            words.Add("N", "n");
            words.Add("O", "ɔ");
            words.Add("P", "p");
            words.Add("Q", "c");
            words.Add("R", "ɾ");
            words.Add("S", "s");
            words.Add("T", "t");
            words.Add("U", "u");
            words.Add("V", "v");
            words.Add("X", "d͡z");
            words.Add("Y", "y");
            words.Add("Z", "z");

            return words;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            {


                
              
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        // Function used to check dictionary and convert the word in Czech
        private void button2_Click(object sender, EventArgs e)
        {
            string albaniansourceword = textBox1.Text;
            foreach (KeyValuePair<string, string> pair in CzechDictionary())
            {
                albaniansourceword = Regex.Replace(albaniansourceword, pair.Key, pair.Value, RegexOptions.IgnoreCase);
            }

            textBox2.Text = albaniansourceword;

            if (textBox1.Text.Length  == 0)
            {

                lblErr1.Visible = true;

            }
            else
            {

                lblErr1.Visible = false;
            }

        }
       
        // Function used to check dictionary and convert the word in Phonetics
        private void button3_Click(object sender, EventArgs e)
        {
            string AlbInput = textBox1.Text;

            foreach (KeyValuePair<string, string> pair in AlbanianDictionary())
            {
                AlbInput = Regex.Replace(AlbInput, pair.Key, pair.Value, RegexOptions.IgnoreCase);
            }

            textBox2.Text = AlbInput;


            if (textBox1.Text.Length == 0)
            {
            // Show error if the user has not inserted any word
                lblErr1.Visible = true;

            }
            else
            {

                lblErr1.Visible = false;
            }

        }



    }
}

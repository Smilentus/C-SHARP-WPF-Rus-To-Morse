using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianToMorse_v2._0
{
    public partial class Form1 : Form
    {
        #region Словарь 1
        public Dictionary<char, string> rusToMorse = new Dictionary<char, string>()
        {
            {' ', ""},
            {'*', " "},
            {'а', ".-"},
            {'б', "-..."},
            {'в', ".--"},
            {'г', "--."},
            {'д', "-.."},
            {'е', "."},
            {'ж', "...-"},
            {'з', "--.."},
            {'и', ".."},
            {'й', ".---"},
            {'к', "-.-"},
            {'л', ".-.."},
            {'м', "--"},
            {'н', "-."},
            {'о', "---"},
            {'п', ".--."},
            {'р', ".-."},
            {'с', "..."},
            {'т', "-"},
            {'у', "..-"},
            {'ф', "..-."},
            {'х', "...."},
            {'ц', "-.-."},
            {'ч', "---."},
            {'ш', "----"},
            {'щ', "--.-"},
            {'ъ', "--.--"},
            {'ы', "-.--"},
            {'ь', "-..-"},
            {'э', "..-.."},
            {'ю', "..--"},
            {'я', ".-.-"},

            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
        };
        #endregion

        #region Словарь 2
        public Dictionary<string, char> MorseToRus = new Dictionary<string, char>()
        {
            {".-",'а'},
            {"-...",'б'},
            {".--",'в'},
            {"--.",'г'},
            {"-..",'д'},
            {".",'е'},
            {"...-",'ж'},
            {"--..",'з'},
            {"..",'и'},
            {".---",'й'},
            {"-.-",'к'},
            {".-..",'л'},
            {"--",'м'},
            {"-.",'н'},
            {"---",'о'},
            {".--.",'п'},
            {".-.",'р'},
            {"...",'с'},
            {"-",'т'},
            {"..-",'у'},
            {"..-.",'ф'},
            {"....",'х'},
            {"-.-.",'ц'},
            {"---.",'ч'},
            {"----",'ш'},
            {"--.-",'щ'},
            {"--.--",'ъ'},
            {"-.--",'ы'},
            {"-..-",'ь'},
            {"..-..",'э'},
            {"..--",'ю'},
            {".-.-",'я'},

            {".----", '1'},
            {"..---", '2'},
            {"...--", '3'},
            {"....-", '4'},
            {".....", '5'},
            {"-....", '6'},
            {"--...", '7'},
            {"---..", '8'},
            {"----.", '9'},
            {"-----", '0'},

        };
        #endregion
        public Form1()
        {
            {
                InitializeComponent();
            }
        }

        private void RussianToMorse()
        {
            string inputR = tB_RTM.Text.ToLower().Trim();
            string outputR = "";
            foreach (char c in inputR)
                if (rusToMorse.ContainsKey(c))
                    outputR += rusToMorse[c] + " ";
            tB_RTMres.Text = outputR;
        }

        private void MorseToRussian()
        {
            try
            {
                string inputM = tB_MTR.Text.Trim();
                string outputM = "";
                string[] split = inputM.Split(new Char[] {' '});
                foreach (string s in split)
                    outputM += MorseToRus[s];
                tB_MTRres.Text = outputM.ToUpper();
            }catch(Exception)
            {
                MessageBox.Show("Нечитаемые символы! Попробуйте ТОЧКИ и ТИРЕ :D");
            }
        }

        private void btn_RTM_Click(object sender, EventArgs e)
        {
            RussianToMorse();
        }

        private void btn_MTR_Click(object sender, EventArgs e)
        {
            MorseToRussian();
        }
    }
}

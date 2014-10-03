using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace jumble
{
    public partial class game : PhoneApplicationPage
    {
        public game()
        {
            InitializeComponent();
        }
        string[] wordList = new string[50];
        string[] hintList = new string[50];     //WORD ARRAY
        int advanceCounter = 0;                 //USED TO GET THE NEXT WORD
        string newWord;
        int score = 0;
        Random randomizer = new Random();
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            wordList[0] = "rscuci";
            wordList[1] = "gerti";
            wordList[2] = "ionl";
            hintList[0] = "circus";
            hintList[1] = "tiger";
            hintList[2] = "lion";
            wordList[3] = "optato";
            hintList[3] = "potato";
            wordList[4] = "lapen";
            hintList[4] = "plane";
            wordList[5] = "gmoan";
            hintList[5] = "mango";
            wordList[6] = "enlnr";
            hintList[6] = "learn";
            hintList[7] = "maps";
            wordList[7] = "psam";
            hintList[8] = "facebook";
            wordList[8] = "kceoafob";
            hintList[9] = "google";
            wordList[9] = "loeogg";
            hintList[10] = "button";
            wordList[10] = "tnotub";
            hintList[11] = "first";
            wordList[11] = "rtifs";
            hintList[12] = "movie";
            wordList[12] = "eoimv";
            hintList[13] = "project";
            wordList[13] = "oeptjrc";
            hintList[14] = "jumbled";
            wordList[14] = "mejdulb";
            hintList[15] = "background";
            wordList[15] = "kogcdaunrb";
            hintList[16] = "page";
            wordList[16] = "aegp";
            hintList[17] = "phone";
            wordList[17] = "oehpn";
            hintList[18] = "computer";
            wordList[18] = "poerctum";
            hintList[19] = "banana";
            wordList[19] = "aanban";
            hintList[20] = "grapes";
            wordList[20] = "pagser";
            hintList[21] = "america";
            wordList[21] = "macaire";
            hintList[22] = "monitor";
            wordList[22] = "trioonm";
            hintList[23] = "linux";
            wordList[23] = "iulxn";
            hintList[24] = "elephant";
            wordList[24] = "htenepla";
            hintList[25] = "surprise";
            wordList[25] = "rreiupss";
            hintList[26] = "beautiful";
            wordList[26] = "fbleutaui";
            hintList[27] = "donkey";
            wordList[27] = "yeodkn";
            hintList[28] = "whisky";
            wordList[28] = "sykwih";
            hintList[29] = "quantum";
            wordList[29] = "muaqnut";
            hintList[30] = "deficit";
            wordList[30] = "tfiidce";
            hintList[31] = "sensex";
            wordList[31] = "xnssee";
            hintList[32] = "school";
            wordList[32] = "ohlosc";
            hintList[33] = "university";
            wordList[33] = "stveriuyni";
            hintList[34] = "coal";
            wordList[34] = "loca";
            hintList[35] = "anxiety";
            wordList[35] = "tiyenxa";
            hintList[36] = "petrol";
            wordList[36] = "rleotp";
            hintList[37] = "europe";
            wordList[37] = "rpueoe";
            hintList[38] = "joker";
            wordList[38] = "eokrj";
            hintList[39] = "property";
            wordList[39] = "toeppyrr";
            hintList[40] = "stampede";
            wordList[40] = "mdeetpas";
            hintList[41] = "abet";
            wordList[41] = "eabt";
            hintList[42] = "euphoria";
            wordList[42] = "rpeiahou";
            hintList[43] = "tantrum";
            wordList[43] = "tmrautn";
            hintList[44] = "exodus";
            wordList[44] = "oeudsx";
            hintList[45] = "clamour";
            wordList[45] = "lrcuoam";
            hintList[46] = "sovereign";
            wordList[46] = "genesiorv";
            hintList[47] = "vivacious";
            wordList[47] = "iocuvvsia";
            hintList[48] = "impasse";
            wordList[48] = "sasipem";
            hintList[49] = "aplomb";
            wordList[49] = "mplboa";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            advanceCounter = randomizer.Next(0, 49);
            newWord = wordList[advanceCounter];
            ab.Text = newWord;
            tx.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string res = tx.Text;
            //string resupp = res.ToUpper();
            //string hintlow = hintList[advanceCounter].ToLower();
            if (res == "")
            {
                MessageBox.Show("You have not entered any letter");
                sc.Text = score.ToString();
            }
            else if (res == hintList[advanceCounter])
            {
                MessageBox.Show("Well Done !! you won");
                score++;
                sc.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("Wrong Guess!! Check the correct answer");
                sc.Text = score.ToString();
            }
            tx.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Correct answer is " + hintList[advanceCounter]);
        }
    }
}
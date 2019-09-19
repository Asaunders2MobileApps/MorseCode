using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCodeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private static string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };

        private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };
        private string input;

        public static char MorseCoder(string code)
        {
            char result = '?';
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(code))
                {
                    result = letters[i];
                    break;
                }
            }
            return result;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (input != "")
            {
                //this if else can be replaced with a terinary 

                //if (oLetter.Text.Equals(""))
                //{
                //    oLetter.Text = Convert.ToString(MorseCoder(input));
                //}
                //else
                //{
                //    oLetter.Text += Convert.ToString(MorseCoder(input));
                //}

                oLetter.Text = oLetter.Text.Equals("") ? Convert.ToString(MorseCoder(input)) : oLetter.Text + Convert.ToString(MorseCoder(input));

                input = "";
            }
            else
            {
                oLetter.Text += " ";
            }
        }

        private void MorseDot(object sender, EventArgs e)
        {
            input += Convert.ToString(iDot.Text);
        }
        private void MorseDash(object sender, EventArgs e)
        {
            input += Convert.ToString(iDash.Text);
        }
    }
}
}

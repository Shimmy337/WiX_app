using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQBF
{
    public class tqbf
    {
        //The quick brown fox dll
        string text = "The quick brown fox jumps over the lazy dog.";

        //Multiplies the text by as many times the number it receives
        public string tqbfMultiplier(int a)
        {
            string output = "";
            try
            {
                for(int i = 0; i <= a; i++)
                {
                    output += i.ToString() + " " + text + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                output += "1. " + text;
            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment2_Winter2022_Mahshad.Controllers
{
    // <summary>
    // Inputs a word and returns a "YES" if the word only contains following letters: I, O, S, H, Z, X, N
    // else returns "NO"
    // Problem J2: Rotating Letters from 2013 
    // https://cemc.math.uwaterloo.ca/contests/computing/2013/stage1/juniorEn.pdf
    // </summary>
    // <param name="word">String that code will check letters ins </param>
    // <example>
    // GET: api/J2/RotatingLetters/NIOSXZ
    // </example>
    // <returns><
    // YES
    // /returns>
    // <example>
    // GET: api/j2/RotatingLetters/aaaa 
    // </example>
    // <returns>
    // NO
    // </returns>
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/RotatingLetter/{word}")]
        public string RotatingLetters(string word)
        {
            string[] BadLetters = {"A", "B", "C", "D", "E", "F", "G", "J", "K",
                                "L", "M", "P", "Q", "R", "T", "U", "V",
                                "W", "Y"};
            int Num = 0;
            int BadNum = 0;

            foreach (string i in BadLetters)
            {
                if (word.Contains(i))
                {
                    BadNum--;
                }
                else
                {
                    Num++;
                }

            }

            string message = "";

            if (BadNum < 0)
            {
                message += "No";
            }
            else
            {
                message += "Yes";
            }

            return message;
        }
    }
}

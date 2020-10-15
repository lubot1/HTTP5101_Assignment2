using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [Route("api/J3/Rovar/{word}")]
        [HttpGet]
        public string Rovar(string word)
        {
            //J3 question obtained from 2015 CCC [https://cemc.math.uwaterloo.ca/contests/computing/2015/stage%201/juniorEn.pdf]
            var replacementString = new List<char>();
            for(int i = 0; i < word.Length; i++)
            {
                //Strings are just arrays of characters so I exploited this to access every index in the array, match it to a character
                //and then hard code the rules dictated by the challenge (Switch statements were the easiest way to do this)
                //Strings are immutable in c# so I had to create a new list to assign the new characters to and then convert that into a string to get my output

                switch(word[i])
                {
                    case 'a':
                        replacementString.Add('a');
                        break;
                    case 'b':
                        replacementString.Add('b');
                        replacementString.Add('a');
                        replacementString.Add('c');
                        break;
                    case 'c':
                        replacementString.Add('c');
                        replacementString.Add('a');
                        replacementString.Add('d');
                        break;
                    case 'd':
                        replacementString.Add('d');
                        replacementString.Add('e');
                        replacementString.Add('f');
                        break;
                    case 'e':
                        replacementString.Add('e');
                        break;
                    case 'f':
                        replacementString.Add('f');
                        replacementString.Add('e');
                        replacementString.Add('g');
                        break;
                    case 'g':
                        replacementString.Add('g');
                        replacementString.Add('e');
                        replacementString.Add('h');
                        break;
                    case 'h':
                        replacementString.Add('h');
                        replacementString.Add('i');
                        replacementString.Add('j');
                        break;
                    case 'i':
                        replacementString.Add('i');
                        break;
                    case 'j':
                        replacementString.Add('j');
                        replacementString.Add('i');
                        replacementString.Add('k');
                        break;
                    case 'k':
                        replacementString.Add('k');
                        replacementString.Add('i');
                        replacementString.Add('l');
                        break;
                    case 'l':
                        replacementString.Add('l');
                        replacementString.Add('i');
                        replacementString.Add('m');
                        break;
                    case 'm':
                        replacementString.Add('m');
                        replacementString.Add('o');
                        replacementString.Add('n');
                        break;
                    case 'n':
                        replacementString.Add('n');
                        replacementString.Add('o');
                        replacementString.Add('p');
                        break;
                    case 'o':
                        replacementString.Add('o');
                        break;
                    case 'p':
                        replacementString.Add('p');
                        replacementString.Add('o');
                        replacementString.Add('q');
                        break;
                    case 'q':
                        replacementString.Add('q');
                        replacementString.Add('o');
                        replacementString.Add('r');
                        break;
                    case 'r':
                        replacementString.Add('r');
                        replacementString.Add('o');
                        replacementString.Add('s');
                        break;
                    case 's':
                        replacementString.Add('s');
                        replacementString.Add('u');
                        replacementString.Add('t');
                        break;
                    case 't':
                        replacementString.Add('t');
                        replacementString.Add('u');
                        replacementString.Add('v');
                        break;
                    case 'u':
                        replacementString.Add('u');
                        break;
                    case 'v':
                        replacementString.Add('v');
                        replacementString.Add('u');
                        replacementString.Add('w');
                        break;
                    case 'w':
                        replacementString.Add('w');
                        replacementString.Add('u');
                        replacementString.Add('x');
                        break;
                    case 'x':
                        replacementString.Add('x');
                        replacementString.Add('u');
                        replacementString.Add('y');
                        break;
                    case 'y':
                        replacementString.Add('y');
                        replacementString.Add('u');
                        replacementString.Add('z');
                        break;
                    case 'z':
                        replacementString.Add('z');
                        replacementString.Add('u');
                        replacementString.Add('z');
                        break;
                }
            }
            string finalString = new string(replacementString.ToArray());
            return finalString;
        }
    }
}

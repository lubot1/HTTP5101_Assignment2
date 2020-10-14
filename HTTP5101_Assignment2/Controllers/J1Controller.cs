using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace HTTP5101_Assignment2.Controllers
{
    
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public int Menu(int burger, int drink, int side, int dessert)
        {
            int calories = 0;

            //Choosing between menu items was going to involve a ton of if else's so I used switch statements
            switch(burger)
            {
                case 1:
                    calories = calories + 461;
                    break;
                case 2:
                    calories = calories + 431;
                    break;
                case 3:
                    calories = calories + 420;
                    break;
                case 4:
                    calories = calories + 0;
                    break;
            }

            switch (drink)
            {
                case 1:
                    calories = calories + 130;
                    break;
                case 2:
                    calories = calories + 160;
                    break;
                case 3:
                    calories = calories + 118;
                    break;
                case 4:
                    calories = calories + 0;
                    break;
            }

            switch (side)
            {
                case 1:
                    calories = calories + 100;
                    break;
                case 2:
                    calories = calories + 57;
                    break;
                case 3:
                    calories = calories + 70;
                    break;
                case 4:
                    calories = calories + 0;
                    break;
            }

            switch (dessert)
            {
                case 1:
                    calories = calories + 167;
                    break;
                case 2:
                    calories = calories + 266;
                    break;
                case 3:
                    calories = calories + 75;
                    break;
                case 4:
                    calories = calories + 0;
                    break;
            }
            return calories;
        }
    }
}

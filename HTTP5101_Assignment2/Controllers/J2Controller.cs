using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/PandemicModel/{population}/{initial_infected}/{R0}")]
        [HttpGet]
        public double PandemicModel(int population, double initial_infected, int R0)
        {
            //Problem obtained from J2 question for the CCC2020 [https://cemc.math.uwaterloo.ca/contests/computing/2020/ccc/juniorEF.pdf]
            int days = 0;
            double infected = 0;

            //Loop through days until the number of infected is greater than the population
            while (infected < population)
            {
                days++;
                //Infected grow exponentially according to how many people are currently infected and what the transmission rate R0 is
                infected = (infected + initial_infected*Math.Pow(R0,(days)));
            }
            return days;
        }
    }
}

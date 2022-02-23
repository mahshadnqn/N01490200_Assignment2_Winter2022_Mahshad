using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment2_Winter2022_Mahshad.Controllers
{
    public class J3Controller : ApiController
    {
        // <summary>
        // Inputs 4 strings and returns the directions (Left or right) and the Location (e.g. MAIN street)
        // J3: Returning Home
        // </summary>
        // <param name="FirstTurn">Left of right</param>
        // <param name="FirstLocation">Different street locations</param>
        // <param name="SecondTurn">Second left or right</param>
        // <param name="SecondLocation">Second Location</param>
        // <example>
        // GET: api/J3/ReturningHome/L/MAIN/R/QUEEN 
        // </example>
        // <returns>
        // Turn LEFT on MAIN street. Turn right on QUEEN street
        // </returns>
        // GET: api/J3/ReturningHome/R/MAIN/L/MAIN
        // </example>
        // <returns>
        // Turn RIGHT on MAIN street. Turn Left on MAIN street
        // </returns>



        [HttpGet]
        [Route("api/J3/ReturningHome/{FirstTurn}/{FirstLocation}/{SecondTurn}/{SecondLocation}")]
        public string ReturningHome(string FirstTurn, string FirstLocation, string SecondTurn, string SecondLocation)
        {
            string Message = "";

            //first sentence

            if (FirstTurn == "R")
            {
                Message += "Turn RIGHT on\n";
            }
            else if (FirstTurn == "L")
            {
                Message += "Turn LEFT on\n";
            }

            if (FirstLocation == "QUEEN")
            {
                Message += "QUEEN street\n";
            }
            else if (FirstLocation == "MAIN")
            {
                Message += "MAIN street\n";
            }
            else if (FirstLocation == "FOURTH")
            {
                Message += "FOURTH street\n";
            }
            else if (FirstLocation == "SCHOOL")
            {
                Message += "the SCHOOL\n";
            }

            //second sentence
            if (SecondTurn == "R")
            {
                Message += "Turn RIGHT on\n";
            }
            else if (SecondTurn == "L")
            {
                Message += "Turn LEFT on\n";
            }

            if (SecondLocation == "QUEEN")
            {
                Message += "QUEEN street\n";
            }
            else if (SecondLocation == "MAIN")
            {
                Message += "MAIN street\n";
            }
            else if (SecondLocation == "FOURTH")
            {
                Message += "FOURTH street\n";
            }
            else if (SecondLocation == "SCHOOL")
            {
                Message += "the SCHOOL\n";
            }

            return Message;
        }
    }
}

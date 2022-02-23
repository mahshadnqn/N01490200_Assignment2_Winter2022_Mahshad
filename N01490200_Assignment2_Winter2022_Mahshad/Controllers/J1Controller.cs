using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment2_Winter2022_Mahshad.Controllers
{
    public class J1Controller : ApiController
    {

        // <summary>
        // Inputs 4 menu options and outputs the combines total of all 4 ints
        // </summary>
        // <param name="BurgerNum"> Burgers number choice</param>
        // <param name="DrinkNum"> Drink number choice</param>
        // <param name="SideNum"> Side meal number choice</param>
        // <param name="DessertNum"> Dessert number choice</param>
        // <example>
        // GET: api/J1/Menu/2/2/2/2
        // </example>
        // <returns><
        // Your total calorie count is 914
        // /returns>
        // <example>
        // GET: api/j1/menu/3/3/3/3 
        // </example>
        // <returns>
        // Your total calorie conut is 683
        // </returns>




        [HttpGet]
        [Route("api/J1/Menu/{BurgerNum}/{DrinkNum}/{SideNum}/{DessertNum}")]
        public string Menu(int BurgerNum, int DrinkNum, int SideNum, int DessertNum)
        {
            int[] burgerChoices = new int[] { 461, 431, 420, 0 };
            int[] drinkChoices = new int[] { 130, 160, 118, 0 };
            int[] sideChoices = new int[] { 100, 57, 70, 0 };
            int[] dessertChoices = new int[] { 167, 266, 75, 0 };

            int TotalCalories = burgerChoices[BurgerNum - 1] + drinkChoices[DrinkNum - 1]
                                + sideChoices[SideNum - 1] + dessertChoices[DessertNum - 1];

            string message = "Your total calorie count is " + TotalCalories.ToString();
            message.ToCharArray();
            return message;


        }
    }
}

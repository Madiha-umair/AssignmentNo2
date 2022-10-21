using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentNo2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// At Fast Food emporium there's a menu, who's each food item is selected by entering a digit choice.(can be 1,2,3,4)
        /// </summary>
        /// <example> GET ../api/J1/Menu/4/4/4/4   -->  Your total calorie count is 0</example>
        /// <example> GET ../api/J1/Menu/1/2/3/  -->  Your total calorie count is 691</example>
        /// <param name="burger"> Input integer representing the index burger choice </param>
        /// <param name="drink"> Input integer representing the index drink choice</param>
        /// <param name="sideOrder"> Input integer representing the index side choice</param>
        /// <param name="dessert"> Integer representing the index dessert choice</param>
        /// <returns>A string which describe in integer"the total Calories of the meal".</returns>
        [Route("api/J1/menu/{burger}/{drink}/{sideOrder}/{dessert}")]
        [HttpGet]

        public string menu(int burger, int drink, int sideOrder, int dessert)
        {
            int caloriecount = 0;

            if (burger==1)
            {
                caloriecount+=461;
            }
            else if (burger==2)
            {
                caloriecount+=431;
            }
            else if (burger==3)
            {
                caloriecount+=420;
            }
            else
            {
                caloriecount+=0;
            }
            if (drink==1)
            {
                caloriecount+=130;
            }
            else if (drink==2)
            {
                caloriecount+=160;
            }
            else if (drink==3)
            {
                caloriecount+=118;
            }
            else
            {
                caloriecount+=0;
            }
            if (sideOrder==1)
            {
                caloriecount+=100;
            }
            else if (sideOrder==2)
            {
                caloriecount+=57;
            }
            else if (sideOrder==3)
            {
                caloriecount+=70;
            }
            else
            {
                caloriecount+=0;
            }
            if (dessert==1)
            {
                caloriecount+=167;
            }
            else if (dessert==2)
            {
                caloriecount+=266;
            }
            else if (dessert==3)
            {
                caloriecount+=75;
            }
            else
            {
                caloriecount+=0;
            }
            return ("Yout total calorie count is " + caloriecount);
        }
    }
}

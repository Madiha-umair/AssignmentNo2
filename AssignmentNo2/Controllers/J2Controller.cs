using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using System.Xml.Schema;

namespace AssignmentNo2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 1-Diana is playing a game with two dice. One dice has m sides, other dice has n sides.
        /// 2-Program determines how many ways she can roll the value of 10.
        /// 3-For eg. when the first die has 6 sides(m= 6) and the second die has 8 sides(n= 8), there are 5 ways to get the sum 10.
        /// 4-All possible combinations of both the dice  can be achieved using nested FOR loops with limits m and n.
        /// 5-And an integer counter "combination" initialze it with zero.
        /// 6-It will incremented when the condition is true i.e;sum of 2 dice=10.
        /// 7-After all the possible combinations has been checked by IF condition, 
        /// 8-Integer "combination" will return the total count of combinatons having sum=10.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <example>eg. GET ../api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10. </example>
        /// <example>eg. GET ../api/J2/DiceGame/3/3 -> There are 0 total ways to get the sum 10. </example>
        /// <example>eg. GET ../api/J2/DiceGame/5/5-> There are 1 total ways to get the sum 10. </example>
        /// <returns>A string which describes in integer, {int} total ways to get the sum 10</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]

        public string DiceGame(int m,int n)
        {
            int combinations = 0;
            int start = 1;
            for (int i= start; i<=m; i++)
            {
                for (int j= start; j<=n; j++)
                {
                    if (i+j ==10)
                        combinations++; 
                    else
                        combinations+=0;
                }
            }
            return ("There are " +combinations + " total ways to get the sum 10");  
        }
    }
}

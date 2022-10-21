using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentNo2.Controllers
{
    /// <summary>
    /// PROBLEM J3(2007)
    /// 
    /// 1- Input number n(0<n<11) from user: 
    ///     int n= "Enter how many brief cases are remaining:"
    ///     n=3
    ///     
    /// 2- Loop run n+1 times, because in last it will take input of banker offer
    ///     for(int i=0; i<=n; i++)
    ///     {
    ///     array remaining[];
    ///     remaining[i]= "Enter brief case number  that is remaining to open and in last enter banker cash offer" :
    ///     }
    ///     
    /// NOW EXPLAINATION:   
    /// This loop will execute n+1 times i.e; 4, this is how we get the number of each brief case remaining to open and last value is banker offer
    ///     like : 4,1,6,198000
    ///     Now, 
    ///     remaining[0]=4
    ///     remaining[1]=1
    ///     remaining[2]=6
    ///     remaining[3]=198000
    ///     
    ///
    ///  3- for(int i=0; i<n; i++)
    ///     {
    ///      if (remaining[i]==1)
    ///         remaining[i]=100;
    ///     else if (remaining[i]==2)
    ///         remaining[i]=500;
    ///     else if (remaining[i]==3)
    ///         remaining[i]=1000;
    ///     else if (remaining[i]==4)
    ///         remaining[i]=5000;
    ///     else if (remaining[i]==5)
    ///         remaining[i]=10000;
    ///     else if (remaining[i]==6)
    ///         remaining[i]=25000;
    ///     else if (remaining[i]==7)
    ///         remaining[i]=50000;
    ///         else if (remaining[i]==8)
    ///         remaining[i]=100000;
    ///     else if (remaining[i]==9)
    ///         remaining[i]=500000;
    ///     else if (remaining[i]==10)
    ///         remaining[i]=1000000;
    ///         
    /// 
    ///NOW EXPLAINATION:
    ///This loop will run only n times i.e;3
    ///  remaining[0]  -->  4= 5000
    ///  remaining[1]  -->  1= 100
    ///  remaining[2]  -->  6= 25000
    ///  
    ///     
    /// 4-    int Total_remaining=0;
    ///     Total_remaining+= remaining[i];
    ///     
    ///NOW EXPLAINATION: 
    /// Total_remaining= remaining[0]+remaining[1]+remaining[2]
    /// Total_remaining= 5000+ 100 + 25000;
    /// Total_remaining=30100;
    ///     }
    ///
    /// 5-    int Banker_offer= remaining[i]
    ///     
    ///NOW EXPLAINATION:  
    ///when loop will reach the limit, it will have  incremented value of i and then it will check again for condition  if (i<n),
    ///at that time i=3 and condition become false, now that last value of array will assign to an integer "Banker_offer"
    ///    remaining[3]= 198000

    /// 6- Decimal average= total_remaining/n;
    /// 
    /// NOW EXPLAINATION:
    /// taking average of the remaining amount
    /// 
    /// 7- string answer;
    ///    If (average < Banker_offer)
    ///         answer= "Deal Done";
    ///    else 
    ///         answer= "Deal not Done";
    ///    return (answer);
    ///    
    /// NOW EXPLAINATION:
    /// If the average value of the remaining brief cases is less than Banker cash offer
    /// Then "Deal is Done" otherwise "Deal not Done".
    ///     
    /// </summary>

    public class J3Controller : ApiController
    {
    }
}

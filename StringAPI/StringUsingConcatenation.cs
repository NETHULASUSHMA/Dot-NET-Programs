using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAPI
{
    internal class StringUsingConcatenation
    {
        string nowDateTime = "Date: " + DateTime.Now.ToString("D");  
        string firstName = "sushma";  
        string lastName = "Manu";  
        string age = "33";  
        string authorDetails = firstName + " " + lastName + " is " + age + " years old.";   
        Console.WriteLine(nowDateTime);  
        Console.WriteLine(authorDetails);  
    }
}

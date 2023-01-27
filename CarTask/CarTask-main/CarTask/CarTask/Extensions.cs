using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
    public static class Extensions
    {
        public  static string CapitalizeFirstTwoLetter(this string name,int count)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            else
            {
                string cod= name.Substring(0, 2).ToUpper()+$"{1000+count}";
                return cod;
            }
            
        }
    }
}

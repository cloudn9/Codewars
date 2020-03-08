using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class ListFilterer
    {
        public static IEnumerable<int> Solution(List<object> listOfItems)
        {
            return listOfItems.Where((k) =>
           {
               var t = k.GetType();
               var p = 0;               
               var res = int.TryParse(k.ToString(), out p);
               return res == true && t.IsPrimitive && t != typeof(char);
           }).Cast<int>().ToList();
        }
    }

}

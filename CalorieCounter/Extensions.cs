using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieCounter
{
    public static class Extensions
    {
        public static void Rearrangelist<T>(this List<T> list,int i)
        {
            foreach (var item in list.Where(x=>list.IndexOf(x)>i))
            {
                var oldindex = list.IndexOf(item);
                var newindex = oldindex - i;
                list.RemoveAt(newindex);
                list.RemoveAt(oldindex);
                list.Insert(newindex, item);
            }
        }
    }
}

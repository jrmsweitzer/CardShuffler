using System;
using System.Collections.Generic;
using System.Linq;

namespace SDO.Extensions
{
    public static class ListExtension
    {
        public static List<T> Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            var tempList = list;
            var shuffledList = new List<T>();

            while (tempList.Any())
            {
                var index = rng.Next(0, tempList.Count - 1);
                var item = tempList[index];
                tempList.RemoveAt(index);
                shuffledList.Add(item);
            }
            return shuffledList;
        }        
    }
}

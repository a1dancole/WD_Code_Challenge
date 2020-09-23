using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZombieDice.Shared.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Shuffle<T>(this List<T> list)
        {
            var rnd = new Random();
            return list.Select(o => new {value = o, order = rnd.Next()}).OrderBy(o => o.order).Select(o => o.value)
                .ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore_sample
{
    public class generate_warnings<T>
    {
        public static List<TOut> ConvertAll<T, TOut>(Func<T, TOut> convert, List<T> items)
        {
            return items.Select(convert).ToList();
        }
    }
}
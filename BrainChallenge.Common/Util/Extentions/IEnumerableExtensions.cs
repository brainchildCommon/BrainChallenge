﻿using System;
using System.Collections.Generic;

namespace BrainChallenge.Common.Util.Extentions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (var item in enumeration)
            {
                action(item);
            }
        }
    }
}

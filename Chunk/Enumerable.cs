using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


static class EnumerablException
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> scoure, int size)
    {
        if (scoure == null) throw new ArgumentNullException(nameof(scoure));
        if (size < 1) throw new ArgumentException("사이즈는 1보다 작을수 없습니다.", nameof(scoure));
        for (int i = 1; i <= size; i++)
        {
            yield return scoure;
        }
    }
}



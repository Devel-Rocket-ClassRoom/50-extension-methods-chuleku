using System;
using System.Collections.Generic;
using System.Text;

static class ShuffleList
{
    public static T[] Shuffle<T>(T[] array)
    {
        if(array == null) throw new ArgumentNullException(nameof(array));
        Random random = new Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = array[k];
            array[k] = array[n];
            array[n] = value;
        }
        return array;
    }
}
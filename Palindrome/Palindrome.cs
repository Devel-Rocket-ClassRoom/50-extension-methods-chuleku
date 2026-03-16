using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class Palindrome
{
    public static bool IsPalidrome(this string s)
    {
        if(s ==null|| s=="")
        {
            return false; 
        }
        var org = s.Where(c => char.IsLetterOrDigit(c))
            .Select(c => char.ToLower(c));
        var filtering = org.ToArray();
        return filtering.SequenceEqual(filtering.Reverse());
    }
}

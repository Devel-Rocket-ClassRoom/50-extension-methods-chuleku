using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindrome
{
    public bool IsPalidrome(string s)
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

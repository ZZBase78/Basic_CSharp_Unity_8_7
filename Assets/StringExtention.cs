using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZZBase.Lession07
{
    public static class StringExtention
    {
        public static int CharCount(this string s, char ch)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ch) count++;
            return count;
        }
    }
}

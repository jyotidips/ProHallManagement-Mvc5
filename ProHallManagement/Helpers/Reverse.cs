﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProHallManagement.Helpers
{
    public static class Reverse
    {
        public static string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
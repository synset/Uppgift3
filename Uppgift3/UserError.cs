using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public abstract class UserError
    {
        //???: konstruktor
        public string Str;
        public abstract UEMessage(string str)
        {
            Str = str;
        }
    }

    
}

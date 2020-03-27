using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public class NumericInputError : UserError
    {
        //???konstruktor
        public override UEMessage(string str)
        {
            Console.WriteLine("You tried to use a text input in a numeric only field. This fired an error!");
        }
    }
}

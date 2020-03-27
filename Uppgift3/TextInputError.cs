using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3
{
    public class TextInputError : UserError
    {
        //???: hur skapa konstruktorn
        public TextInputError();
        {
            //ToDo: kod
        }

        public override UEMessage(string str)
        {
            Console.WriteLine("You tried to use a numeric input in a text only field. This fired an error!");
        }
    }
}

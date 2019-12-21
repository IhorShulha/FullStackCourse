using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Text : Printer
    {
        string _text { get; set; }
        public Text(string value) : base(value)
        {
            _text = value;
        }
    }
}

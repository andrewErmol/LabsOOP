using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibrary
{
    public class MyException : Exception
    {
        public string Value { get; }
        public MyException(string message) : base(message) { }

        public MyException(string message, string val) : base(message)
        {
            Value = val;
        }
    }
}

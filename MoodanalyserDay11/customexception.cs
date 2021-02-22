using System;
using System.Collections.Generic;
using System.Text;

namespace MoodanalyserDay11
{
    public class moodanalyserCustomeexception : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            EMPTY_MOOD,
            EMPTY_NULL
        }
        public moodanalyserCustomeexception(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

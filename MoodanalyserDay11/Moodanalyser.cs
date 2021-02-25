using System;
using System.Collections.Generic;
using System.Text;

namespace MoodanalyserDay11
{
   public  class Moodanalyser
    {
       private string message;

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <returns></returns>
        public Moodanalyser(string message)
        {
            this.message = message;
        }
        
        public string AnalyseMood()
        {
            if (this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}

using System;

namespace MoodanalyserDay11
{
    public class Moodanalyser
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
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <returns></returns>
        public Moodanalyser()
        {
            this.message = "I am in SAD mood";
        }
       
        public string AnalyseMood()
        {
            try
            {
                
                if (this.message.Contains("SAD"))

                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
                

            }

        }
    }
}


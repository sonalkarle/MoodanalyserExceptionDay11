﻿using System;

namespace MoodanalyserDay11
{
    public class Moodanalyser
    {
        private string message;

        public Moodanalyser(string message)
        {
            this.message = message;
        }
        public Moodanalyser()
        {
            this.message = "I am in SAD mood";
        }
        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))

                    throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.EMPTY_MOOD, "Mood should not be empty");

                else if (this.message.Contains("SAD"))

                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.EMPTY_NULL, "Mood should not be null");
                return "HAPPY";

            }

        }
    }
}

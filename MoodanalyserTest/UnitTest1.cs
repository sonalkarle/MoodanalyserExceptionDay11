using NUnit.Framework;
using MoodanalyserDay11;

namespace MoodanalyserTest
{
    public class Tests
    {
        Moodanalyser moodanalyser;
        [SetUp]
        public void Setup()
        {
          
            moodanalyser = new Moodanalyser();

        }
        /// <summary>
        /// UC1.1: Given message "I am in SAD mood" returns SAD
        /// </summary>
        [Test]
        public void Given_message_In_SAD_Mood_return_SAD_message()
        {
            //Arrange
            string message = "I am in SAD Mood";
            moodanalyser = new Moodanalyser(message);
            //Act
            string expected = "SAD";
            string actual = moodanalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        ///<summary>
        ///UC1.2: Given message "I am in any mood" return HAPPY
        ///</summary>
        [Test]
        public void Given_message_return_In_Any_Mood_return_Happy_message()
        {
            //Arrange
            string message = "I am in Any Mood";
            moodanalyser = new Moodanalyser(message);
            //Act
            string expected = "HAPPY";
            string actual = moodanalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///UC1.1:Handle null exception return as invalid
        /// </summary>
        [Test]
        public void Handle_NullException_return_Invalid()
        {
            //Arrange 
            string message = null;
           moodanalyser = new Moodanalyser(message);
            //Act
            string expected = "INVALID";
            string actual = moodanalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
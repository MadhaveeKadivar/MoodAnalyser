using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class MoodTesting
    {
        [TestMethod] //TC 1.1 SAD mood testing
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string exepected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            //Act
            string actual = moodAnalyzer.AnalyzeMood(message);
            //Assert
            Assert.AreEqual(exepected, actual);
        }

        [TestMethod] //TC 1.2 Happy mood testing - If there is no sad word in message then returns happy mood
        public void GivenAnyMoodShouldReturnHappy()
        {
            //Arrange
            string exepected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            //Act
            string actual = moodAnalyzer.AnalyzeMood(message);
            //Assert
            Assert.AreEqual(exepected, actual);
        }
    }
}

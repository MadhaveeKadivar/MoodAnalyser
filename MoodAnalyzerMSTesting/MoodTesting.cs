using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class MoodTesting
    {      
        [TestMethod] //Refactor TC 1.1 SAD mood testing
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string exepected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string actual = moodAnalyzer.AnalyzeMood();
            //Assert
            Assert.AreEqual(exepected, actual);
        }
        [TestMethod] //Refactor TC 1.2 Happy mood testing - If there is no sad word in message then returns happy mood
        public void GivenAnyMoodShouldReturnHappy()
        {
            //Arrange
            string exepected = "HAPPY";
            string message = "I am in happy mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string actual = moodAnalyzer.AnalyzeMood();
            //Assert
            Assert.AreEqual(exepected, actual);
        }
        [TestMethod] // TC 2.1 If message is null then returns happy mood
        public void GivenNULLMoodShouldReturnHappy()
        {
            //Arrange
            string exepected = "HAPPY";
            string message = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string actual = moodAnalyzer.AnalyzeMood();
            //Assert
            Assert.AreEqual(exepected, actual);
        }
    }
}

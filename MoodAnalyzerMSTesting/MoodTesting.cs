using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerMSTesting
{
    [TestClass]
    public class MoodTesting
    {
        MoodAnalyzerFactory moodAnalyzerFactory;
        /// <summary>
        /// Common Arrange for all test cases
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            moodAnalyzerFactory = new MoodAnalyzerFactory();
        }
        /// <summary>
        /// Refactor TC 1.1 - Given “I am in Sad Mood” message Should Return SAD
        /// </summary>
        [TestCategory("Exception")]
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
        /// <summary>
        /// Refactor TC 1.2 Given “I am in Any Mood” message Should Return HAPPY
        /// </summary>
        [TestCategory("Exception")]
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
        /// <summary>
        /// TC 2.1 Given Null Mood Should Return Happy
        /// </summary>
        //TestMethod] // TC 2.1 If message is null then returns happy mood
        //public void GivenNULLMoodShouldReturnHappy()
        //{
        //    //Arrange
        //    string exepected = "HAPPY";
        //    string message = null;
        //    MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
        //    //Act
        //    string actual = moodAnalyzer.AnalyzeMood();
        //    //Assert
        //    Assert.AreEqual(exepected, actual);
        //}
        /// <summary>
        /// TC 3.1 - Given NULL Mood Should Throw MoodAnalysisException
        /// </summary>
        [TestCategory("Exception")]
        [TestMethod] // TC 3.1 If message is null then throws the MoodAnalysisexception
        public void GivenNullMoodThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                //Act
                string actual = moodAnalyzer.AnalyzeMood();
                
            }
            catch(MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
        /// <summary>
        /// TC 3.2 - Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [TestCategory("Exception")]
        [TestMethod] // TC 3.2 If message is empty then throws the MoodAnalysisexception
        public void GivenEmptyMoodThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                //Act
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("Message should not be empty", ex.Message);
            }
        }
        /// <summary>
        /// TC 4.1 Given MoodAnalyser Class Name Should Return MoodAnalyser
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenClassNameShoulReturnObject()
        {           
            object expected = new MoodAnalyzer();
            object actual = moodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(actual);           
        }
        /// <summary>
        /// TC 4.2 Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidClassThrowException()
        {
            try
            {
                object expected = new MoodAnalyzer();
                object actual = moodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.Mood", "Mood");
            }
            catch(MoodAnalysisException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// TC 4.3 Given Constructor Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidConstructorThrowException()
        {
            try
            {
                object expected = new MoodAnalyzer();
                object actual = moodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer","Mood");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
        /// <summary>
        /// Extra - Given Class Name not match with constructor then Throw MoodAnalysisException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenNullConstructorNameThrowException()
        {
            try
            {
                object expected = new MoodAnalyzer();
                object actual = moodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer",null);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Class name or constructor name should not be null", ex.Message);
            }
        }
        
    }
}

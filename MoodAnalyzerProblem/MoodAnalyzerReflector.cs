using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerReflector
    {
        public string InvokeMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyzer);
                MethodInfo methodInfo = type.GetMethod(methodName);
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                object moodAnalyzerObject = factory.CreateMoodAnalyzerParameterizedObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", message);
                object info = methodInfo.Invoke(moodAnalyzerObject, null);
                return info.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.METHOD_NOT_FOUND, "Method not found");
            }
        }   
    }
}

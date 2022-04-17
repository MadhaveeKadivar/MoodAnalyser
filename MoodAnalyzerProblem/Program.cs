using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nWelcome to Mood Analyzer");           
            //Console.WriteLine("\nEnter any message : ");
            //string message = Console.ReadLine();
            //MoodAnalyzer moodAnalyzer = new MoodAnalyze(message); //Creating a object of MooddAnalyzer class
            //string mood = moodAnalyzer.AnalyzeMood(); // calling method of class with paasing user message as parameter
            //Console.WriteLine($"\n{mood} mood");
            MoodAnalyzerFactory moodAnalyzerFactory = new MoodAnalyzerFactory();
            moodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            MoodAnalyzerReflector moodAnalyzerReflector = new MoodAnalyzerReflector();
            moodAnalyzerReflector.InvokeMethod("Madhavee", "AnalyzeMood");

            Console.ReadLine();
        }
    }
}

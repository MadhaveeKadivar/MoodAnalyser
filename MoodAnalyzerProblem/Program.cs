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
            Console.WriteLine("\nWelcome to Mood Analyzer");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(); //Creating a object of MooddAnalyzer class
            Console.WriteLine("\nEnter any message : ");
            string message = Console.ReadLine();
            string mood = moodAnalyzer.AnalyzeMood(message); // calling method of class with paasing user message as parameter
            Console.WriteLine($"\n{mood} mood");
            Console.ReadLine();
        }
    }
}

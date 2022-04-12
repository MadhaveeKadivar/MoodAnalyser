using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message) // Creating method to find mood based on message
        {
            if(message.ToLower().Contains("sad")) // If message contains sad word then return sad mood else return happy mood
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

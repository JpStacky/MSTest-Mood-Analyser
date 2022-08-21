using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class CustomExceptionUC3
    {
        public void analyseMood(string message)
        {
            string result = "Happy Mood";
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Sad Mood");
            else if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Happy Mood");
            else
                throw new MoodAnalysisException("Exception Mood Happy");
        }
    }
}

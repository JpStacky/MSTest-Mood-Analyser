namespace MoodAnalyzerProblem
{
    public class HandleExceptionUC2
    {
        public void analyseMood(string message)
        {
            string result = "Happy Mood";
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Sad Mood");
            else if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Happy Mood");
            else 
                throw new Exception("Exception Mood Happy");
        }
    }
}

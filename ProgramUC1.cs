namespace MoodAnalyzerProblem
{
    public class ProgramUC1
    {
        public static void Main()
        {
            Console.Write("Enter A Message = ");
            string message = Console.ReadLine();

            MoodAnalyserUC1 moodAnalyserUC1 = new MoodAnalyserUC1();
            string result = moodAnalyserUC1.analyseMood(message);
            Console.WriteLine(result);
        }
    }
}

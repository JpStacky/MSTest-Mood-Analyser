namespace MoodAnalyzerProblem
{
    public class ProgramUC3
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter A Message = ");
                string message = Console.ReadLine();
                CustomExceptionUC3 customExceptionUC3 = new CustomExceptionUC3();
                customExceptionUC3.analyseMood(message);
            }
            catch (MoodAnalysisException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

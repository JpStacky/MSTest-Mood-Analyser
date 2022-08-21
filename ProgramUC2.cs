namespace MoodAnalyzerProblem
{
    public class ProgramUC2
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter A Message = ");
                string message = Console.ReadLine();

                HandleExceptionUC2 handleExceptionUC2 = new HandleExceptionUC2();
                handleExceptionUC2.analyseMood(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

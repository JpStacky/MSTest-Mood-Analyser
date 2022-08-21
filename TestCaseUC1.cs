using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class TestCaseUC1
    {
        [TestMethod]
        public void When_Given_Sad_Message()
        { 
            MoodAnalyserUC1 moodAnalyserUC1 = new MoodAnalyserUC1();
            string result = moodAnalyserUC1.analyseMood("i am sad");
            Assert.AreEqual(result, "Sad Mood");
        }
    }
}

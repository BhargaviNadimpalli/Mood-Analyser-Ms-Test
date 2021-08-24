using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyseMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveClassNameAndReturnObject()
        {
            string message = null;
            object expected = new Mood();
            object obj = MoodAnalyser.CreateMoodAnalyse("MoodAnalyserMsTest.Mood", "Mood");
            expected.Equals(obj);
        }
    }
}

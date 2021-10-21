using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
         Job testJobObject1 = new Job();
         Job testJobObject2 = new Job();

            Assert.IsFalse(testJobObject1.Equals(testJobObject2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer acme = new Employer("Acme");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job testJobObject1 = new Job("Product tester", acme, desert, qualityControl, persistence);

            Assert.AreEqual("Product tester", testJobObject1.Value);
            Assert.AreEqual("Acme", testJobObject1.EmployerName.Value);
            Assert.AreEqual("Desert", testJobObject1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJobObject1.JobType.Value);
            Assert.AreEqual("Persistence", testJobObject1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer acme = new Employer("Acme");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job testJobObject1 = new Job("Product tester", acme, desert, qualityControl, persistence);
            Job testJobObject2 = new Job("Product tester", acme, desert, qualityControl, persistence);

            Assert.IsFalse(testJobObject1.Equals(testJobObject2));
        }

        [TestMethod]
        public void ToStringReturnStartsAndEndsWithBlankLine()
        {
            Employer acme = new Employer("Acme");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job testJobObject1 = new Job("Product tester", acme, desert, qualityControl, persistence);
            string testObjectString = testJobObject1.ToString();

            Assert.IsTrue(testObjectString.StartsWith($"\n") && testObjectString.EndsWith("\n")); 
        }

        [TestMethod]
        public void ToStringReturnIsFormatted()
        {
            Employer acme = new Employer("Acme");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job testJobObject1 = new Job("Product tester", acme, desert, qualityControl, persistence);
            string testObjectString = testJobObject1.ToString();

            Assert.IsTrue(testObjectString == $"\nID: {testJobObject1.Id} \n" +
                $"Name: {testJobObject1.Value} \n" +
                $"Employer: {testJobObject1.EmployerName.Value} \n" +
                $"Location: {testJobObject1.EmployerLocation.Value} \n" +
                $"Position Type: {testJobObject1.JobType.Value} \n" +
                $"Core Competency: {testJobObject1.JobCoreCompetency.Value} \n");

        }

    }
}

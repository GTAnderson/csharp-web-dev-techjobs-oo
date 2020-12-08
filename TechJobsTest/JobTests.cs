using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTest
    {
        // TODO: Test the Empty Constructor

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job("Name1", "EmployerName1", "EmployerLocation1", "JobType1", "CoreCompetency1");
            Job test_job2 = new Job("Name2", "EmployerName2", "EmployerLocation2", "JobType2", "CoreCompetency2");
            Assert.AreEqual(test_job1.Id, test_job2.Id, 1);
        }

        // TODO: Test the Full Constructor

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual(test_job3.Name, "Product tester");
            Assert.AreEqual(test_job3.EmployerName, "ACME");
            Assert.AreEqual(test_job3.EmployerLocation, "Desert");
            Assert.AreEqual(test_job3.JobType, "Quality control");
            Assert.AreEqual(test_job3.CoreCompetency, "Persistence");
        }

        // TODO: Test the Equals() Method

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("EqualJobName", "EqualEmployerName", "EqualEmployerLocation", "EqualJobType", "EqualCoreCompetency");
            Job test_job5 = new Job("EqualJobName", "EqualEmployerName", "EqualEmployerLocation", "EqualJobType", "EqualCoreCompetency");
            Assert.IsFalse(test_job4.Id.Equals(test_job5.Id));
        }

        // TODO: Test the ToString() Method

        [TestMethod]
        public void TestJobsForToString()
        {
            Job test_job6 = new Job("ToStrJobName", "ToStrEmployerName", "ToStrEmployerLocation", "ToStrJobType", "ToStrCoreCompetency");
            StringAssert.StartsWith(test_job6.ToString(), "\n");
            StringAssert.EndsWith(test_job6.ToString(), "\n");

            StringAssert.Contains(test_job6.ToString(), "ID:  " + test_job6.Id + "\n");
            StringAssert.Contains(test_job6.ToString(), "Name:  " + test_job6.Name + "\n");
            StringAssert.Contains(test_job6.ToString(), "Employer:  " + test_job6.EmployerName + "\n");
            StringAssert.Contains(test_job6.ToString(), "Location:  " + test_job6.EmployerLocation + "\n");
            StringAssert.Contains(test_job6.ToString(), "Position Type:  " + test_job6.JobType + "\n");
            StringAssert.Contains(test_job6.ToString(), "Core Competency:  " + test_job6.CoreCompetency + "\n");

            Job test_job7 = new Job("ToStrJobName", "", "", "", "");
            Assert.AreEqual(test_job7.Name, "Data not available");
            Assert.AreEqual(test_job7.EmployerName, "Data not available");
            Assert.AreEqual(test_job7.EmployerLocation, "Data not available");
            Assert.AreEqual(test_job7.JobType, "Data not available");
            Assert.AreEqual(test_job7.CoreCompetency, "Data not available");
        }
    }
}
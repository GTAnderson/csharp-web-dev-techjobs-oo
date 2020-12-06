using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTest
    {
        /* TODO: Test the Empty Constructor
        1. In JobTests, define a test called TestSettingJobId.
        2. Create two Job objects using the empty constructor. Use
        Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID
        values for the two objects are NOT the same and differ by 1.
        3. Run the test to verify that your Job() constructor correctly assigns ID
        numbers.
        */

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job("Name1", "EmployerName1", "EmployerLocation1", "JobType1", "JobCoreCompetency1");
            Job test_job2 = new Job("Name2", "EmployerName2", "EmployerLocation2", "JobType2", "JobCoreCompetency2");
            Assert.AreEqual(test_job1.Id, test_job2.Id, 1);
        }

        /* TODO: Test the Full Constructor
        1. In JobTest, define a test called TestJobConstructorSetsAllFields.
        2. Declare and initialize a new Job object with the following data:
        "Product tester" for Name, "ACME" for EmployerName, "Desert" for EmployerLocation,
        "Quality control" for JobType, and "Persistence" for JobCoreCompetency.
        3. Use Assert statements to test that the constructor correctly assigns the value of each field.
        */

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual(test_job3.Name, "Product tester");
            Assert.AreEqual(test_job3.EmployerName, "ACME");
            Assert.AreEqual(test_job3.EmployerLocation, "Desert");
            Assert.AreEqual(test_job3.JobType, "Quality control");
            Assert.AreEqual(test_job3.JobCoreCompetency, "Persistence");
        }

        /* TODO: Test the Equals() Method
        1. In JobTest, define a test called TestJobsForEquality.
        2. Generate two Job objects that have identical field values EXCEPT for id.
        Test that Equals() returns false.
        */

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("EqualJobName", "EqualEmployerName", "EqualEmployerLocation", "EqualJobType", "EqualJobCoreCompetency");
            Job test_job5 = new Job("EqualJobName", "EqualEmployerName", "EqualEmployerLocation", "EqualJobType", "EqualJobCoreCompetency");
            Assert.IsFalse(test_job4.Id.Equals(test_job5.Id));
        }

    }
}
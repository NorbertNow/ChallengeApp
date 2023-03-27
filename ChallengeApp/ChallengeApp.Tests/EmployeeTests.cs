namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        // ================ TEST 1 =======================================================
        [Test]
        public void WhenPositivePointsAreAdded_ThenShouldReturnCorrectTotal()
        {
            // ==============Arrange==================

            var employee = new Employee("Norbert", "Nowak", 51);
            employee.AdScore(5);
            employee.AdScore(6);
            employee.AdScore(8);

            // ================Act=====================

            int result = employee.Result;

            // ===============Assert===================

            Assert.AreEqual(19, result);

        }

        // ================ TEST 2 ========================================================


        [Test]
        public void WhenNegativePointsAreAdded_ThenShouldReturnCorreectTotal()
        {
            // ==============Arrange===================

            var employee = new Employee("Norbert", "Nowak", 51);
            employee.AdScore(-5);
            employee.AdScore(-6);
            employee.AdScore(-8);

            // ===============Act=======================

            int result = employee.Result;

            // ==============Assert=====================

            Assert.AreEqual(-19, result);
        }

        // ================ TEST 3 ========================================================


        [Test]
        public void WhenMixedPointsAreAdded_ThenShouldReturnCorrectTotal()
        {
            // =============Arrange=====================

            var employee = new Employee("Norbert", "Nowak", 51);
            employee.AdScore(5);
            employee.AdScore(-6);
            employee.AdScore(8);

            // ==============Act=========================

            int result = employee.Result;

            // =============Assert=======================

            Assert.AreEqual(7, result);
        }
    }
}
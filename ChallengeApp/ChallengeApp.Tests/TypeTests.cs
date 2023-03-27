namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        // ------------------- VALUE TYPE (INTEGER) TEST --------------------------------
        [Test]
        public void IntegerTypeTest()
        {
            // ARRANGE
        
            int number1 = 1;
            int number2 = 1;
            
            // ACT

            // ASSERT

            Assert.AreEqual(number1, number2);
        }

        // ------------------- VALUE TYPE (FLOAT) TEST --------------------------------
        [Test]
        public void FloatTypeTest()
        {
            // ARRANGE

            float number1 = 2.5456f;
            float number2 = 2.5456f;

            // ACT

            // ASSERT

            Assert.AreEqual(number1, number2);
        }

        // ------------------- IMMUTABLE TYPE (STRING) TEST --------------------------------
        [Test]
        public void StringTypeTest()
        {
            // ARRANGE

            string name1 = "Jan";
            string name2 = "Jan";

            // ACT

            // ASSERT

            Assert.AreEqual(name1, name2);
        }

        // --------------------- REFERENCE TYPE TEST -------------------------------
        [Test]
        public void ReferenceTypeTest() 

        // ARRANGE
        {
            var employee1 = GetEmployee("Jan", "Kowalski", 30);
            var employee2 = GetEmployee("Jan", "Kowalski", 30);
        // ACT

        // ASSERT

        Assert.AreNotEqual(employee1, employee2);
        
        }
        
        // --------------------- PRIVATE METHOD -------------------------------------------
        private Employee GetEmployee (string name, string surname, int age) 
        {
            return new Employee (name, surname, age);
        }
    
    }
}

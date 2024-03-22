namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        
        public void Test1()
        {
            //arrange
            var employee1 = new Employee("Dominik", "Warchol", 27);
            employee1.AddScore(5);
            employee1.AddScore(3);
            employee1.AddScore(-5);

            //act
            var result = employee1.Result;

            //Assert
            Assert.AreEqual(3, result);


        }

        public void Test2()
        {
            //arrange
            var employee2 = new Employee("Jan", "Kowalski", 31);
            employee2.AddScore(8);
            employee2.AddScore(-4);
            employee2.AddScore(6);

            //act
            var result = employee2.Result;

            //Assert
            Assert.AreEqual(3, result);


        }
    }
}

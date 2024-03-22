namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenNamesAreDifferent()

        {
            // arrange 
            var employee1 = GetEmployee("Dominik", "Warchol", 27);
            var employee2 = GetEmployee("Jan", "Kowalski", 31);


            // act 

            // assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void WhenSurnamesAreDifferent()
        {
            // arrange 
            var employee1 = GetEmployee("Dominik", "Warchol", 27);
            var employee3 = GetEmployee("Magdalena", "Jaœkowiak", 29);


            // act 

            // assert
            Assert.AreNotEqual(employee1.Surname, employee3.Surname);
        }

        [Test]
        public void WhenAgesAreDifferent()
        {
            // arrange 
            var employee2 = GetEmployee("Jan", "Kowalski", 31);
            var employee3 = GetEmployee("Magdalena", "Jaœkowiak", 29);


            // act 

            // assert
            Assert.AreNotEqual(employee2.Age, employee3.Age);
        }

        [Test]
        public void WhenTheResultsAreTheSame()
        {
            // arrange 
            var employee1 = GetEmployee("Dominik", "Warchol", 27);
            var employee2 = GetEmployee("Jan", "Kowalski", 31);


            // act 

            // assert
            Assert.AreEqual(employee1.Result, employee2.Result);
        }



        Employee GetEmployee(string name, string Surname, int Age)
        {
            return new Employee(name, Surname, Age);
        }

    }
}

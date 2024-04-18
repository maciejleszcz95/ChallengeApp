/*
Zadanie domowe dzien 9
Testy jednostkowe poprawnosci dzialania klasy Employee oraz modelu danych Statistics
 */

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void SettingNameAndSurname_ShouldReturnNameAndSurname()
        {
            // arrange
            var employee = new Employee("Adam", "Kamizelich");

            // assert
            Assert.That(employee.Name, Is.EqualTo("Adam"));
        }

        [Test]
        public void GettingStatistics_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(10);
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Average, Is.EqualTo(6));
        }

        [Test]
        public void GettingStatistics_ShouldReturnCorrectMaximumValue()
        {
            // arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(10);
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Max, Is.EqualTo(10));
        }

        [Test]
        public void GettingStatistics_ShouldReturnCorrectMinimumValue()
        {
            // arrange
            var employee = new Employee("Adam", "Kamizelich");
            employee.AddGrade(10);
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(4);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(statistics.Min, Is.EqualTo(4));
        }
    }
}

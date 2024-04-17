namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void CompareTwoIdenticalStrings_ShouldReturnEqual()
        {
            // arrange
            string text1 = "Adam";
            string text2 = "Adam";

            // assert
            Assert.AreEqual(text1, text2);
        }

        [Test]
        public void CompareTwoIdenticalIntegers_ShouldReturnEqual()
        {
            // arrange
            int number1 = 50;
            int number2 = 50;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareTwoIdenticalFloatingPointNumbers_ShouldReturnEqual()
        {
            // arrange
            float number1 = 56.89f;
            float number2 = 56.89f;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareTwoIdenticalObjects_ShouldReturnNotEqual()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}

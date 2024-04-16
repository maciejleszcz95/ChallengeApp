
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrecResult()
        {
            // arrange
            var user = new User("Adam", "asaasad");
            user.AddScore(5);
            user.AddScore(6);

            // act
            int result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenUserCollectTwoPenaltyScores_ShouldReturnCorrecResult()
        {
            // arrange
            var user = new User("Adam", "asaasad");
            user.PenaltyScore(5);
            user.PenaltyScore(10);

            // act
            int result = user.Result;

            // assert
            Assert.AreEqual(-15, result);
        }
        [Test]
        public void WhenUserCollectBothPenaltyScoreAndScore_ShouldReturnCorrecResult()
        {
            // arrange
            var user = new User("Adam", "asaasad");
            user.AddScore(15);
            user.PenaltyScore(10);

            // act
            int result = user.Result;

            // assert
            Assert.AreEqual(5, result);
        }
    }
}
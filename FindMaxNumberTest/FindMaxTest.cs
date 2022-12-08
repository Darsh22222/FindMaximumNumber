using FindMaxNumber;

namespace FindMaxNumberTest
{
    public class Tests
    {
        FindMaximumNumber maxNum = new FindMaximumNumber();
        [Test]
        public void GivenMaxFirstNumber_WhenAnalysed_ShouldReturn_FirstMax()
        {
            //AAA- ARRANGE, ACT, ASSERT
            int result = maxNum.FindMaxInteger(20, 15, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalysed_ShouldReturn_SecondMax()
        {
            int result = maxNum.FindMaxInteger(15, 20, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalysed_ShouldReturn_ThirdMax()
        {
            int result = maxNum.FindMaxInteger(15, 5, 20);
            Assert.AreEqual(20, result);
        }
    }
}
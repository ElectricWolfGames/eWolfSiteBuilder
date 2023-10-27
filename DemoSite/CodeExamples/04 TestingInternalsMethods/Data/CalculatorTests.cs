namespace Code.UnitTest
{
    public class Tests
    {
        [TestCase("1+2", "3")]
        [TestCase("123-23", "100")]
        [TestCase("1-2", "-1")]
        public void ShouldAddNumbers(string process, string expectedResult)
        {
            var code = new Calculator();
            var result = code.ProcessCalculation(process);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ShouldAddReturnAddedValues()
        {
            var code = new Calculator();
            var result = code.Add(1, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void ShouldSubReturnSubValues()
        {
            var code = new Calculator();
            var result = code.Sub(1, 1);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
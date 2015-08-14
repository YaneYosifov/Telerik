namespace RotatingWalkInMatrix.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class UserInputTests
    {
        [Test]
        [TestCase("1")]
        [TestCase("3")]
        [TestCase("12")]
        [TestCase("37")]
        [TestCase("54")]
        [TestCase("89")]
        [TestCase("99")]
        [TestCase("100")]
        public void InputNumberShouldBeAcceptedIfItIsBetweenOneAndOneHundred(string validNumber)
        {
            int number = UserInput.GetNumber(validNumber);
            Assert.IsTrue(1 <= number && number <= 100);
        }

        //[Test]
        //[TestCase("0")]
        //[TestCase("-1")]
        //[TestCase("101")]
        //[TestCase("37694352363757956213445778965674254856425268232780124")]
        //[TestCase("str")]
        //[TestCase("тест")]
        //[TestCase(".")]
        //[TestCase("\"")]
        //[ExpectedException(typeof(Exception))]
        //public void InputNumberShouldNotBeAcceptedIfItIsNotBetweenOneAndOneHundred(string validNumber)
        //{
        //    int number = UserInput.GetNumber(validNumber);
        //    Assert.IsFalse(1 <= number && number <= 100);
        //}
    }
}

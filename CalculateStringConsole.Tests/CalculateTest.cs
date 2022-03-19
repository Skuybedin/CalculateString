using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateStringConsole.Tests
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CalcWordCount_return_3()
        {
            //arrange
            CalculateString calc = new CalculateString("Привет, как дела? :)");
            int expected = 3;

            //act
            int result = calc.CalcWordCount();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalcWordCount_return_9()
        {
            //arrange
            CalculateString calc = new CalculateString("Меня зовут Никита, мне 25 лет и я из Москвы");
            int expected = 9;

            //act
            int result = calc.CalcWordCount();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalcWordCount_return_8()
        {
            //arrange
            CalculateString calc = new CalculateString("She said, that she will come here tommorow");
            int expected = 8;

            //act
            int result = calc.CalcWordCount();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLanguage_return_Russian()
        {
            //arrange
            CalculateString calc = new CalculateString("Какая сегодня красивая погода!");
            string expected = "Русский";

            //act
            string result = calc.GetLanguage();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLanguage_return_English()
        {
            //arrange
            CalculateString calc = new CalculateString("My favorite food is Pizza!");
            string expected = "English";

            //act
            string result = calc.GetLanguage();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalcVowelCount_return_6()
        {
            //arrange
            CalculateString calc = new CalculateString("Ааа! Что это?");
            int expected = 6;

            //act
            int result = calc.CalcVowelCount();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalcVowelCount_return_7()
        {
            //arrange
            CalculateString calc = new CalculateString("Wow! It looks amazing");
            int expected = 7;

            //act
            int result = calc.CalcVowelCount();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}

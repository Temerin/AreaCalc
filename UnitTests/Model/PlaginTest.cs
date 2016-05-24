using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalc;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    class PluginTest //Тестируется класс Circle
    {
        //Тестирование свойства Area;
        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование fretGuitar при присванивании 20.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование fretGuitar при присванивании максимального допустимого значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue-1, TestName = "Тестирование fretGuitar при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование fretGuitar при присванивании минимального допустимого значения.")]
        [TestCase(1.93, TestName = "Тестирование fretGuitar при присванивании Min+1.")]

        public void PositiveFretTest(double rad) //Сам позитивный тест.
        {
            var circle = new Сircle(rad);
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование fretGuitar при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование fretGuitar при присванивании 0.")]
        [TestCase(-1, TestName = "Тестирование fretGuitar при присванивании Max+1.")]
        [TestCase(0, TestName = "Тестирование fretGuitar при присванивании Min-1.")]
        public void NotPositiveFretTest(double rad) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            var ex = Assert.Throws<FigureExeption>(() => new Сircle(rad)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование outletGuitar при присванивании 20.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование outletGuitar при присванивании максимального допустимого значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование outletGuitar при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование outletGuitar при присванивании минимального допустимого значения.")]
        [TestCase(1.93, TestName = "Тестирование outletGuitar при присванивании Min+1.")]

        public void PositiveOutletTest(double rad) //Сам позитивный тест.
        {
            var circle = new Сircle(rad);
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование outletGuitar при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование outletGuitar при присванивании 0.")]
        [TestCase(-1, TestName = "Тестирование outletGuitar при присванивании Max+1.")]
        [TestCase(0, TestName = "Тестирование outletGuitar при присванивании Min-1.")]
        public void NotPositiveOutletTest(double rad) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            var ex = Assert.Throws<FigureExeption>(() => new Сircle(rad)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

    }
}

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
    class RectangleTest //Тестируется класс Rectangle
    {
        //Тестирование свойства Area;
        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование side1 при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование side1 при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование side1 при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование side1 при присванивании 1,93.")]

        public void PositiveRectangleSide1(double side1) //Сам позитивный тест. То, что находится в параметрах и будет изменяться.
        {
            double side2 = 3;
            var rectangle = new Rectangle(side1,side2);
        }

        [Test]
        [TestCase(10, TestName = "Тестирование side2 при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование side2 при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование side2 при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование side2 при присванивании 1,93.")]
        public void PositiveRectangleSide2(double side2) //Сам позитивный тест. То, что находится в параметрах и будет изменяться.
        {
            double side1 = 3;
            var rectangle = new Rectangle(side1, side2);
        }

        [Test]
        [TestCase(-1, TestName = "Тестирование side1 при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование side1 при присванивании 0.")]
        public void NegativeRectangleSide1(double side1) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            double side2 = 3;
            var ex = Assert.Throws<FigureExeption>(() => new Rectangle(side1, side2)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Недопустимая длина 1. Длина должна быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

        [Test]
        [TestCase(-1, TestName = "Тестирование side2 при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование side2 при присванивании 0.")]
        public void NegativeRectangleSide2(double side2) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            double side1 = 3;
            var ex = Assert.Throws<FigureExeption>(() => new Rectangle(side1, side2)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Недопустимая длина 2. Длина должна быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

    }
}
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
    class TriangleTest //Тестируется класс Rectangle
    {
        //Тестирование свойства Area;
        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование side1 при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование side1 при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование side1 при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование side1 при присванивании 1,93.")]

        public void PositiveTriangleSide1(double side1) //Сам позитивный тест. То, что находится в параметрах и будет изменяться.
        {
            double side2 = 3;
            double side3 = 2;
            var triangle = new Triangle(side1, side2, side3);
        }

        [Test]
        [TestCase(10, TestName = "Тестирование side2 при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование side2 при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование side2 при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование side2 при присванивании 1,93.")]
        public void PositiveTriangleSide2(double side2) //Сам позитивный тест. То, что находится в параметрах и будет изменяться.
        {
            double side1 = 3;
            double side3 = 2;
            var triangle = new Triangle(side1, side2, side3);
        }
        [Test]
        [TestCase(10, TestName = "Тестирование side3 при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование side3 при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue - 1, TestName = "Тестирование side3 при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование side3 при присванивании 1,93.")]
        public void PositiveTriangleSide3(double side3) //Сам позитивный тест. То, что находится в параметрах и будет изменяться.
        {
            double side1 = 3;
            double side2 = 2;
            var triangle = new Triangle(side1, side2, side3);
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование side1 при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование side1 при присванивании 0.")]
        public void NegativeRectangleSide1(double side1) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            double side2 = 3;
            double side3 = 2;
            var ex = Assert.Throws<FigureExeption>(() => new Triangle(side1, side2, side3)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Недопустимая длина 1. Длина должна быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

        [Test]
        [TestCase(-1, TestName = "Тестирование side2 при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование side2 при присванивании 0.")]
        public void NegativeRectangleSide2(double side2) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            double side1 = 3;
            double side3 = 2;
            var ex = Assert.Throws<FigureExeption>(() => new Triangle(side1, side2, side3)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Недопустимая длина 2. Длина должна быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование side3 при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование side3 при присванивании 0.")]
        public void NegativeRectangleSide3(double side3) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            double side1 = 3;
            double side2 = 2;
            var ex = Assert.Throws<FigureExeption>(() => new Triangle(side1, side2, side3)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Недопустимая длина 3. Длина должна быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }

    }
}
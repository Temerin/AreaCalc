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
    class CircleTest //Тестируется класс Circle
    {
        //Тестирование свойства Area;
        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование rad при присванивании 10.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(double.MaxValue, TestName = "Тестирование rad при присванивании максимального значения.")]            //название теста, которое будет выводиться у вас при запуске.
        [TestCase(double.MaxValue-1, TestName = "Тестирование rad при присванивании Max-1.")]
        [TestCase(1.93, TestName = "Тестирование rad при присванивании 1,93.")]

        public void PositiveCyrcle(double rad) //Сам позитивный тест.
        {
            var circle = new Сircle(rad);
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование rad при присванивании -1.")]
        [TestCase(0, TestName = "Тестирование rad при присванивании 0.")]
        public void NegativeCyrcle(double rad) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            var ex = Assert.Throws<FigureExeption>(() => new Сircle(rad)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }
        
    }
}

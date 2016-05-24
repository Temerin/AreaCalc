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
    class KompasAPITest //Тестируется класс Circle
    {
        //Тестирование свойства Area;
        //Позитивный тест. Успешным прохождением считается работа без ошибок.
        [Test]
        [TestCase(10, TestName = "Тестирование при получении корректной ссылки на приложение.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 
        [TestCase(10, TestName = "Тестирование при получении корректной ссылки на документ Компаса.")] //Первый параметр - значение переменной, которое попадет в конструктор. Второй - 


        public void InitPositive(double rad) //Сам позитивный тест.
        {
            var circle = new Сircle(rad);
        }
        [Test]
        [TestCase(-1, TestName = "Тестирование при получении не корректной ссылки на приложение.")]
        [TestCase(0, TestName = "Тестирование при получении не корректной ссылки на документ Компаса.")]
        public void InitNegative(double rad) //Негативный тест. Успешным прохождением считается возникновение конкретного сообщения об ошибке.
        {
            var ex = Assert.Throws<FigureExeption>(() => new Сircle(rad)); //Запуск конструктора и попытка сформировать вашу ошибку.
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля!")); //Сравнение получившейся ошибки с эталонной. При совпадении - тест успешен.
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Начало
{
    // Класс для работы с дробями. Представляет из себя несократимую рациональную дробь.
    // Классы состоят из полей (переменных) и методов (функций).
    class Rational
    {
        // Числитель
        private int a;
        private int b;

        // Конструктор класса - функция, которая вызывается при создании объекта
        // Обычно используется для инициализации полей класса
        public Rational(int a, int b)
        {
            // this - обращение к полям или методам класса
            this.a = a;
            this.b = b;
        }

        // override - переопределение метода ToString()
        // ToString() - метод, определяющий как объект будет преобразовываться в строку, когда это необходимо
        public override string ToString()
        {
            return $"({a}/{b})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основные типы int | float | char | string | bool

            // Целочисленные типы
            byte b; // 0  - 255
            sbyte sb; // -128 - 127
            short s; // -32768 - 32768
            ushort us; // 0 - 65535
            int i; // -2147483648 - 2147483648
            long l; // -9223372036854775808 - 9223372036854775807 
            ulong ul; // 0 - 18446744073709551615

            // Числа с плавающий точкой
            float f = 5.7f; // точность до 10 знаков, нужен префикс f
            double d = 5.7; // точность до 15 знаков

            // Символьный тип 
            char c = 'a'; // для хранения одного символа

            // Строковый тип    
            string st = "hello world"; // для хранения символов больше одного

            // Логический тип
            bool bl = true; // правда (true) или ложь (false)

            // Оператор присваивания =
            // объявили тип 'int' для переменной 'a' и присвоили (=) переменной значения '1'
            int a = 1;

            // чтобы не запоминать минимальные и 
            // максимальные значения типов данных

            // узнать минимальное значение ulong
            Console.WriteLine("Минимальное значение: " + ulong.MinValue);

            // узнать максимальное значение ulong
            Console.WriteLine("Максимальное значение: " + ulong.MaxValue);

            Console.ReadKey();
        }
    }
}

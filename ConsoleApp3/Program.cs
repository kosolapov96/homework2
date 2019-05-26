using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //Задача перевести минуты в секунды, секунды в секунды.

                 int minute, second, a;

                    Console.WriteLine("Введите время(минуты секунды)");

                    minute = Convert.ToInt32(Console.ReadLine());

                    second = Convert.ToInt32(Console.ReadLine());

                    a = minute * 60;

                 if (second <= 60)

                    Console.WriteLine($"{a}, {second}");

                 else
                    Console.WriteLine("Ошибка!!!Секунд не может быть больше 60-ти");
            }

            {
                //Задачка расчитать сумму со скидкой, если сумма больше 500 то скидка 3%, если сумма больше 1000 то скидка 10 %.

                 double cash = 0, discount, discount1;

                    Console.WriteLine("Введите сумму и нажмите <Enter>");

                    cash = Convert.ToDouble(Console.ReadLine());

                    discount = cash - (cash * 0.1);

                    discount1 = cash - (cash * 0.03);

                 if (cash >= 1000)

                    Console.WriteLine("Ваша сумма учитывая скидку:  " + discount);



                 else if (cash >= 500)

                    Console.WriteLine("Ваша сумма учитывая скидку: " + discount1);

                 else
                    Console.WriteLine("Ваша скидка 0%");
            }

            {
                //Узнать частное от деление m на n, если число не делится то вывести сообщение.
                 double m, n, b;

                    Console.WriteLine("Введите число m и n");

                    m = Convert.ToDouble(Console.ReadLine());

                    n = Convert.ToDouble(Console.ReadLine());

                    b = m / n;

                 if (m % n != 0)

                    Console.WriteLine("m на n нацело не делится");

                 else

                    Console.WriteLine("Ответ: " + b);
            }
            {
                 double side, radius, sCircle, sSquare;

                    Console.WriteLine("Введите длину стороны квадрата: ");

                    side = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите длину радиуса: ");

                    radius = Convert.ToDouble(Console.ReadLine());

                    sCircle = (Math.PI * (radius * radius));

                    sSquare = (side * side);

                 if (sCircle>sSquare)

                     Console.WriteLine("Площадь круга больше!!!");
                    
                 else

                     Console.WriteLine("Площадь квадрата больше!!!");
            }
        }       
    }
}

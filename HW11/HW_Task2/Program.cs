using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HW_Task2
{
    class Program
    {
        //Напишите и запустите следующую программу:
        //1.	Подключите к вашему проекту используя директиву using следующие пространства имен:
        //using System.Collections;
        //using System.Diagnostics;
        //using System.Collections.Generic;
        //2.	Создайте в теле метода Main экземпляр класса Stopwatch.Данный класс используется для замеров скорости выполнения участков кода. 
        //3.	Запустите отсчет времени на экземпляре Stopwatch, используя метод Start().
        //4.	Ниже по коду создайте экземпляр list1 класса коллекции List, закрытой object. 
        //5.	В цикле заполните экземпляр элементами типа int числом 1000 000 элементов.
        //6.	После заполнения коллекции вызовите на экземпляре Stopwatch метод Stop(). 
        //7.	Выведите на экран время выполнения вашего кода, обратившись к свойству Elapsed экземпляра Stopwatch. 
        //8.	Вызовите рестарт замера времени выполнения, выполнив метод Restart().
        //9.	Создайте экземпляр list2 коллекции List, закрытой int-ом.
        //10.	Заполните в цикле экземпляр list2 1000 000-м элементов.
        //11.	Остановите отсчет времени и выведите результат на экран. Сравните скорость выполнения.


        static void Main(string[] args)
        {
            while (true)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var list1 = new List<object>();
                for (int i = 0; i < 1000000; i++)
                {
                    list1.Add(new object());
                }
                stopwatch.Stop();
                Console.WriteLine($"List заполнен {list1.GetType()} {stopwatch.Elapsed}");
                stopwatch.Restart();

                var list2 = new List<int>();
                for (int i = 0; i < 1000000; i++)
                {
                    list2.Add(new int());
                }
                stopwatch.Stop();
                Console.WriteLine($"List заполнен {list2.GetType()} {stopwatch.Elapsed}");
                stopwatch.Restart();
                Console.ReadKey();
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}

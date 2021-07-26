using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task1
{
    public interface IInt
    {
         void ShowClassType();
    }
    interface IInt<Y>
    {
         void ShowPropType();
    }
    class Program
    {
        //Создайте интерфейсы IInt и IInt<Y>.В теле интерфейса IInt создайте абстрактный метод без возвращаемого значения и с сигнатурой ShowClassType(), 
        //В теле интерфейса IInt<Y> создайте абстрактное автосвойство типа Y и абстрактный метод без возвращаемого значения с сигнатурой ShowPropType().
        //Создайте класс Class1, реализующий интерфейс IInt, создайте класс Class2, реализующий оба интерфейса.
        //Создайте экземпляры классов Class1 и Class2 в методе Main и продемонстрируйте на них работу созданных методов, исходя из названий используемых методов.

        static void Main(string[] args)
        {
        }
    }
}

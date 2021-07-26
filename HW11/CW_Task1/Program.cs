using System;

namespace CW_Task1
{
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
    class Class1 : IInt
    {
        public void ShowClassType()
        {
            Console.WriteLine(GetType());
        }
    }
    class Class2 : IInt, IInt<int>
    {
        public void ShowClassType()
        {
            Console.WriteLine(); 
        }

        public void ShowPropType()
        {
            this.ShowPropType();
        }
    }
    public interface IInt
    {
        abstract void ShowClassType();
    }
    interface IInt<Y>
    {
        abstract void ShowPropType();
    }
}

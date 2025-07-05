/*Напишите программу, в которой есть производный класс. Класс со-
здается на основе базового класса и реализует интерфейс. Производный
класс, базовый класс и интерфейс описываются в разных пространствах
имен.*/

using FirstNameSpace;
using SecondNamespace;

namespace FirstNameSpace
{
    interface MyInterface { }
}

namespace SecondNamespace 
{ 
    class BaseClass { }
}

namespace ThirdNameSpace
{
    class MyClass: BaseClass, MyInterface { }
}

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*Напишите программу, в которой создается цепочка из объектов, со-
зданных на основе обобщенного класса: имеется последовательность
объектов, и в этой последовательности первый объект ссылается на вто-
рой, второй объект ссылается на третий, и так далее. Обобщенный класс,
помимо прочего, должен содержать поле обобщенного типа и поле, яв-
ляющееся ссылкой на следующий объект в цепочке. Предложите методы
для работы с такой цепочкой объектов.*/

using System;

namespace GenericChainExample
{
    // Обобщённый класс узла цепочки
    public class ChainNode<T>
    {
        public T Value { get; set; }                // Значение текущего узла
        public ChainNode<T> Next { get; set; }      // Ссылка на следующий узел

        public ChainNode(T value)
        {
            Value = value;
            Next = null;
        }

        // Добавление нового элемента в конец цепочки
        public void Add(T newValue)
        {
            ChainNode<T> current = this;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new ChainNode<T>(newValue);
        }

        // Печать всех значений в цепочке
        public void Print()
        {
            ChainNode<T> current = this;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        // Подсчёт количества узлов в цепочке
        public int Count()
        {
            int count = 0;
            ChainNode<T> current = this;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        // Поиск первого элемента, соответствующего условию
        public ChainNode<T> Find(Func<T, bool> predicate)
        {
            ChainNode<T> current = this;
            while (current != null)
            {
                if (predicate(current.Value))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание цепочки целых чисел
            ChainNode<int> chain = new ChainNode<int>(10);
            chain.Add(20);
            chain.Add(30);
            chain.Add(40);

            Console.WriteLine("Цепочка значений:");
            chain.Print();

            Console.WriteLine($"Количество узлов: {chain.Count()}");

            var foundNode = chain.Find(x => x == 30);
            Console.WriteLine($"Найдено значение: {foundNode?.Value ?? -1}");
        }
    }
}


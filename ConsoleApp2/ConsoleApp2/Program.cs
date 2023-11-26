using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Создайте коллекцию(цитрусовые фрукты) из шести элементов.
        static void Fruit(List<string> fruitell)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Введите {i + 1}-ый цитрусовый фрукт: ");
                fruitell.Add(Console.ReadLine());
            }
        }
        static void Letters(List<string> fruitell)
        {
            foreach (var elem in fruitell)
            {
                Console.WriteLine(elem.ToLower());
            }
        }
        static void Main(string[] args)
        {
            List<string> fruite = new List<string>();
            Fruit(fruite);
            Console.WriteLine("Вывод прописными буквами: ");
            Letters(fruite);
            Console.WriteLine($"текущее количество элементов коллекции: {fruite.Count}");
            Console.Write("Введите новый элемент в конец списка: ");
            string a = Convert.ToString(Console.ReadLine());
            fruite.Add(a);
            Letters(fruite);
            Console.Write("Введите новый элемент в начало списка: ");
            string b = Convert.ToString(Console.ReadLine());
            fruite.Insert(0, b);
            Letters(fruite);
            Console.WriteLine("Удаление третьего элемента");
            fruite.RemoveAt(2);
            Letters(fruite);
            Console.WriteLine("Расположение элементов в обратном порядке:");
            fruite.Reverse();
            Letters(fruite);
            Console.ReadKey();
        }
    }
}

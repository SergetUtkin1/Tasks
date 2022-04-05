using System;

namespace FirstTask
{
    class Program
    {
        static int FibonachiNumber(int index) => (index == 0 || index == 1 ? index : (FibonachiNumber(index - 2) + FibonachiNumber(index - 1)));

        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс по который нужно вывести числа Фибоначи:");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(FibonachiNumber(i));
            }
        }
    }
}

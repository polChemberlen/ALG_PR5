//Задание:
//1.Написать алгоритм наглядно показывающий отличие while/doWhile
//2. Вывести последовательность 1 2 4 8 16 32 64 и тд, до числа i, которое мы вводим
//3.Вывести ряд Фибоначчи(рядом чисел, в котором каждое последующее число является
//суммой двух предыдущих: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 и
//    так далее до бесконечности) по количеству чисел в ряду.

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //задание 1
            Console.WriteLine("цикл while");
            int q = 0;
            while (q > 5)
            {
                Console.WriteLine(q);
                q++;

            }

            Console.WriteLine("");

            Console.WriteLine("цикл do while");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j > 5);



            //задание 2
            Console.WriteLine("Введите число: \n");
            int i = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            while (number < i)
            {
                Console.WriteLine(number);
                number = number * 2;
            }



            //задание 3
            Console.WriteLine("Ряд из скольки чисел Фибоначчи вы хотите получить? \n");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int a = 0;
            int b = 1;

            int i = 0;

            while (i < num)
            {
                Console.WriteLine(a);

                int c = a + b;
                a = b;
                b = c;

                i++;
            }

        }
    }

}
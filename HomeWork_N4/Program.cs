using System;

//Решить две задачи с leetcode.
//https://leetcode.com/problems/build-array-from-permutation/ - на массивы

//Учитывая перестановку на основе нуля nums (с индексом 0), постройте массив ans одинаковой длины,
//где ans[i] = nums[nums[i]] для каждого 0 <= i < nums.length и верните его.
//Перестановка на основе нуля nums представляет собой массив различных целых чисел от 0 до nums.length - 1 (включительно).

//https://leetcode.com/problems/defanging-an-ip-address/ - на строки
//Задан допустимый (IPv4) IP address, верните исправленную версию этого IP-адреса.
//Дефангированный IP-адрес заменяет каждую точку "." на "[.]".
//Указанный address является действительным IPv4-адресом.

namespace HomeWork_N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t*** HOME WORK N4 ***\n");
            Console.WriteLine("Выберите задачу из списка:\n");
            Console.WriteLine("\t1. Задача с LeetCode: https://leetcode.com/problems/build-array-from-permutation/ - на массивы." +
                "Учитывая перестановку на основе нуля nums (с индексом 0), постройте массив ans одинаковой длины," +
                "где ans[i] = nums[nums[i]] для каждого 0 <= i < nums.length и верните его." +
                "Перестановка на основе нуля nums представляет собой массив различных целых чисел от 0 до nums.length - 1 (включительно).");
            Console.WriteLine("\t2. Задача с LeetCode: https://leetcode.com/problems/defanging-an-ip-address/ - на строки" +
                "Задан допустимый (IPv4) IP address, верните исправленную версию этого IP-адреса." +
                "Дефангированный IP-адрес заменяет каждую точку \".\" на \"[.]\"." +
                "Указанный address является действительным IPv4-адресом.");
            Console.WriteLine("\t3. Выход из программы.\n");
            Console.WriteLine("Введите номер задачи (цифру и Enter):\n");
            bool exit = false;
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": Tasks.Task_1(); break;
                    case "2": Tasks.Task_2(); break;
                    case "3":
                    case "": exit = true; break;
                    default: Console.WriteLine("Такого пункта нет в списке задач, попробуйте ещё раз."); break;
                }
            } while (!exit);
        }
    }
    public class Tasks
    {
        public static void Task_1()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 4, часть 1. ***\n");
            Console.WriteLine("Задача с LeetCode: https://leetcode.com/problems/build-array-from-permutation/ - на массивы." +
                "Учитывая перестановку на основе нуля nums (с индексом 0), постройте массив ans одинаковой длины," +
                "где ans[i] = nums[nums[i]] для каждого 0 <= i < nums.length и верните его." +
                "Перестановка на основе нуля nums представляет собой массив различных целых чисел от 0 до nums.length - 1 (включительно).");

            //Ввод данных
            Console.Write("Введите размер исходного массива: ");
            short size;
            while(!Int16.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Ошибка! Невозможно преобразовать введенные данные в целое число. Попробуйте ещё раз:");
            }
            short[] nums = new short[size];
            for (int i = 0; i < size; i++)
            {
                bool check = true;
                short value;
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                while (check)
                {
                    check = false;
                    while (!Int16.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Ошибка! Невозможно преобразовать введенные данные в целое число. Попробуйте ещё раз:");
                    }
                    if (value >= size || value < 0)
                    {
                        Console.WriteLine("Число должно быть меньше размера массива и не меньше 0. Попробуйте ещё раз.");
                        check = true;
                    }
                    for (int j = 1; j < i; j++)
                    {
                        if (value == nums[j])
                        {
                            Console.WriteLine("Такое число уже есть. Числа должны быть различными. Попробуйте ещё раз.");
                            check = true;  
                        }
                    }
                    nums[i] = value;
                }
            }

            Console.WriteLine("Вывод исходного массива:");
            Console.WriteLine("Data:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(nums[i]);
                Console.Write('\t');
            }
            Console.WriteLine();

            //Обработка
            short[] ans = new short[size];
            for (int i = 0; i < size; i++)
            {
                ans[i] = nums[nums[i]];
            }

            //Вывод результата
            Console.WriteLine("Вывод получившегося массива:");
            Console.WriteLine("Result:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(ans[i]);
                Console.Write('\t');
            }
            Console.WriteLine();

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
        public static void Task_2()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t *** Задание 4, Задача 2. ***\n");
            Console.WriteLine("Задача с LeetCode: https://leetcode.com/problems/defanging-an-ip-address/ - на строки" +
                "Задан допустимый (IPv4) IP address, верните исправленную версию этого IP-адреса." +
                "Дефангированный IP-адрес заменяет каждую точку \".\" на \"[.]\"." +
                "Указанный address является действительным IPv4-адресом." +
                "Ввод: address = \"255.100.50.0\"\r\nВывод:  \"255[.]100[.]50[.]0\"");

            //Ввод исходных данных
            Console.Write("Введите IP-адрес:");
            string input_str = Console.ReadLine();

            //Обработка данных
            string output_str = input_str.Replace(".", "[.]");
            
            //Вывод результата
            Console.WriteLine("Вывод результата: " + output_str);

            Console.WriteLine("Для возврата в меню нажмите Enter.");
            Console.ReadKey();
            Program.Menu();
        }
        
    }
}

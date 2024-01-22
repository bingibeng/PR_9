using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.Title = "Практическая работа № 9";
            while (true)
            {
                Console.Write("Нажмите Y чтобы продолжить и N чтобы прекратить ");
                string select_key = Console.ReadLine();

                switch (select_key)
                {
                    case "Y":

                        try

                        {
                            Console.WriteLine("Здравствуйте!");
                            //Console.BackgroundColor = ConsoleColor.White;
                            //Console.ForegroundColor = ConsoleColor.Black;
                            Random rand = new Random(); // класс Random() для работы со случайными числами

                            int[] arr = new int[10];
                            Console.WriteLine($"Как хотите ввести чсила?\nЕсли хотите сами нажмите A\nЕсли Вы желаете сгенерировать случайные числа, нажмите B" );
                            string select_key1 = Console.ReadLine();
                            switch (select_key1)
                            {
                                case "A":
                                    {
                                        for (int i = 0; i < 10; i++)
                                        {
                                            Console.Write("Введите значение для элемента массива " + i + ": ");
                                            arr[i] = int.Parse(Console.ReadLine());
                                        }

                                        int negative = 0; // количество отрицательных чисел
                                        int min = Math.Abs(arr[0]); // минимальное по модулю
                                        int element = 0; // номер минимального по модулю элемента в массиве

                                        Console.Write("Массив = {");
                                        for (int i = 1; i < 10; i++)
                                        {
                                            // отрицательные числа
                                            if (arr[i] < 0)
                                                negative++;
                                            // минимальный элемент по модулю
                                            if (Math.Abs(arr[i]) < min)
                                            {
                                                min = Math.Abs(arr[i]);
                                                element = i;
                                            }
                                            Console.Write(arr[i] + ", ");
                                        }
                                        Console.WriteLine("\b\b}\n");

                                        int sum = 0;
                                        for (int i = element + 1; i < 10; i++)
                                        {
                                            sum += Math.Abs(arr[i]);
                                        }

                                        Console.WriteLine("Количество отрицательных чисел в массиве = " + negative);
                                        Console.WriteLine("Минимальный элемент [" + element + "] по модулю = " + min);
                                        Console.WriteLine("Сумма модулей, после минимального = " + sum);
                                        Console.ReadKey();
                                    }
                                break;
                                case "B":
                                    {
                                        Console.Write("Введите левую границу случайных чисел = ");
                                        int left = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Введите правую границу случайных чисел = ");
                                        int right = Convert.ToInt32(Console.ReadLine());
                                        if (left == right)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Конечное и начальное значения одинаковы");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Clear();
                                        }
                                        arr[0] = left;
                                        for (int i = 1; i < 9; i++)
                                        {
                                            arr[i] = rand.Next(-10, 10); // случайные числа от -10 до 10
                                        }
                                        arr[9] = right;

                                        int negative = 0; // количество отрицательных чисел
                                        int min = Math.Abs(arr[0]); // минимальное по модулю
                                        int element = 0; // номер минимального по модулю элемента в массиве

                                        Console.Write("Массив = {");
                                        for (int i = 0; i < 10; i++)
                                        {
                                            // отрицательные числа
                                            if (arr[i] < 0)
                                                negative++;
                                            // минимальный элемент по модулю
                                            if (Math.Abs(arr[i]) < min)
                                            {
                                                min = Math.Abs(arr[i]);
                                                element = i;
                                            }
                                            Console.Write(arr[i] + ", ");
                                        }
                                        Console.WriteLine("\b\b}\n");

                                        int sum = 0;
                                        for (int i = element + 1; i < 10; i++)
                                        {
                                            sum += Math.Abs(arr[i]);
                                        }

                                        Console.WriteLine("Количество отрицательных чисел в массиве = " + negative);
                                        Console.WriteLine("Минимальный элемент [" + element + "] по модулю = " + min);
                                        Console.WriteLine("Сумма модулей, после минимального = " + sum);
                                        Console.ReadKey();
                                    }
                                    break;
                            }
                        }

                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Элемент находится вне границы");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Введите число, а не букву");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: что-то пошло не так" + e.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "N":
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                
                }
            }
        }
    }
}

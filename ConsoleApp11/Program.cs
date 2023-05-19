using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Введите число:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number >= 0)
                    {
                        Console.WriteLine($"{number} + 5 = " + (number + 5));
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine($"{number} - 5 = " + (number - 5));
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите первое число:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    int number3 = Convert.ToInt32(Console.ReadLine());

                    if (number1 > number2 && number1 > number3)
                    {
                        Console.WriteLine("Наибольшее - " + number1);
                    }
                    else if (number2 > number1 && number2 > number3)
                    {
                        Console.WriteLine("Наибольшее - " + number2);
                    }
                    else if (number3 > number1 && number3 > number2)
                    {
                        Console.WriteLine("Наибольшее - " + number3);
                    }
                    break;

                case 3:
                    Console.WriteLine("Введите первое число:");
                    int numer1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int numer2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    int numer3 = Convert.ToInt32(Console.ReadLine());

                    if (numer1 > 0 && numer2 > 0 && numer3 > 0)
                    {
                        Console.WriteLine("Все числа положительные - " + (numer1 + numer2 + numer3));
                    }
                    else if (numer1 > 0 && numer2 > 0 && numer3 < 0)
                    {
                        Console.WriteLine("Два числа положительные - " + (numer1 + numer2));
                    }
                    else if (numer1 < 0 && numer2 > 0 && numer3 > 0)
                    {
                        Console.WriteLine("Два числа положительные - " + (numer2 + numer3));
                    }
                    else if (numer1 > 0 && numer2 < 0 && numer3 > 0)
                    {
                        Console.WriteLine("Два числа положительные - " + (numer1 + numer3));
                    }
                    else if (numer1 > 0 && numer2 < 0 && numer3 < 0)
                    {
                        Console.WriteLine("Одно число положительное - " + numer1);
                    }
                    else if (numer1 < 0 && numer2 > 0 && numer3 < 0)
                    {
                        Console.WriteLine("Одно число положительное - " + numer2);
                    }
                    else if (numer1 < 0 && numer2 < 0 && numer3 > 0)
                    {
                        Console.WriteLine("Одно число положительное - " + numer3);
                    }
                    break;

                case 4:
                    Console.WriteLine("Введите число:");
                    int tenner = Convert.ToInt32(Console.ReadLine());

                    if(tenner>10)
                    {
                        Console.WriteLine($"{tenner} * 2 = " + (tenner*2));
                    }
                    else if(tenner<10)
                    {
                        Console.WriteLine($"Число {tenner} меньше 10.");
                    }
                    else if (tenner == 10)
                    {
                        Console.WriteLine("Число равно 10.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Введите число дня недели:");
                    int week = Convert.ToInt32(Console.ReadLine());
                    switch(week)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;
                        default:
                            Console.WriteLine("Число не соответствует дням недели.");
                            break;
                    }
                    break;

                case 6:
                    int division = 200;
                    while (division % 17 !=0)
                    {
                        division++;
                    }
                    Console.WriteLine("Число - " + division);
                    break;

                case 7:
                    double run = 10;
                    int day = 1;
                    while(run<20)
                    {
                        run = run * 0.05 + run;
                        day++;
                    }
                    Console.WriteLine($"Через {day} дней человек пробежит 20 км.");
                    while (run <= 100)
                    {
                        run = run * 0.05 + run;
                        day++;
                    }
                    Console.WriteLine($"Через {day} дней человек пробежит 100 км.");
                    break;

                case 8:
                    Console.WriteLine("Введите число:");
                    int factorial = Convert.ToInt32(Console.ReadLine());
                    if (factorial == 0) {
                        Console.WriteLine("Факториал этого числа равен 1.");
                    }
                    else
                    {
                        int fact = 1;
                        for (int i = 1;i<=factorial;i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine($"Факториал числа {factorial} равен {fact}");
                    }
                    break;

                case 9:
                    Console.WriteLine("Введите натуральное число:");
                    int natur = Convert.ToInt32(Console.ReadLine());
                    int div = 2;
                    while(natur % div != 0)
                    {
                        div++;
                    }
                    Console.WriteLine($"Наименьший делитель числа {natur} - " + div);
                    break;

            }
           


           


            
        }
    }
}

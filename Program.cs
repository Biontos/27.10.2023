////стр 21 №20
//Console.WriteLine("Введите m точки");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите n точки");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите a точки");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите b точки");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите c точки");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите x точки");
//int x = Convert.ToInt32(Console.ReadLine());
//int y = 0;
//y = a * x * x + b * y + c ;
//if (y == n && x == m)
//    Console.WriteLine("Подходит");
//else
//{
//    Console.WriteLine("Не подходит");
//}

////стр 21 №25
//Console.WriteLine("Введите радиус первого параллепипеда");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите радиус второго параллепипеда");
//double y = Convert.ToDouble(Console.ReadLine());
//while (x == y)
//    Console.WriteLine("Радиусы равны");
//while (x >= y)
//        Console.WriteLine("Первый радиус больше второго");
//while (y >= x)
//    Console.WriteLine("Второй радиус больше первого");

////стр 34 №4
//Console.WriteLine("Введите очередное число");
//double n = Convert.ToDouble(Console.ReadLine());
//double a, b, c;
//a = 0;
//b = 0;
//c = 1;
//for (int i = 1; i <= n; i++)
//{
//    a = a + Math.Cos(i);
//    b = b + Math.Sin(i);
//    c = c * (a / b);
//}

////стр 34 №11
//int sum;
//for (int i = 1; i < 10; i++)
//{
//    sum = (1 + Math.Sin(0.i));
//    Console.WriteLine(sum);
//}

//// стр 39 №22
//double summa = 0;
//Console.WriteLine("Введите число ");
//int a = Convert.ToInt32(Console.ReadLine());
//while (a > 0)
//{
//    Console.WriteLine("Введите число последовательности ");
//    double b = Convert.ToDouble(Console.ReadLine());
//    double c = b % 10;
//    if (c / a == 1)
//        summa += b;
//    else
//        Console.WriteLine("число не оканчивается на заданное");
//    Console.WriteLine("Продолжить ввод?");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine("Сумма последовательности равна = ");

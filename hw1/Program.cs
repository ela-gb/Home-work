// 9. Показать последнюю цифру трёхзначного числа

// int N = new Random().Next(100, 1000);
// System.Console.WriteLine(N);
// System.Console.WriteLine("Третье число" +  "  " + N % 10);
// System.Console.WriteLine("Третье число" +  "  " + N / 100);


///// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int N = new Random().Next(11, 100);
// System.Console.WriteLine(N);
// int a = N / 10; // первое число
// int b = N % 10; // второе число
// if (a > b)
// {
//     System.Console.WriteLine(a);
// }
// else
// {
//     System.Console.WriteLine(b);
// }


///// 12. Удалить вторую цифру трехзначного числа

// int N = new Random().Next(99, 1000);
// System.Console.WriteLine(N);

// int a = N / 100 * 10;
// int b = N % 10;
// int c = a + b;
// System.Console.WriteLine(c);


///// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// int X = new Random().Next(10, 50);
// int Y = new Random().Next(1, 11);
// System.Console.WriteLine(X);
// System.Console.WriteLine(Y);
// int result = X % Y;
// if (result == 0)
// {
//     System.Console.WriteLine(X + "  " + "кратно" + "  " + Y);
// }
// else
// {

//     System.Console.WriteLine("остаток" + "  " + result);
// }
//При делении с остатком выдает случайный результат. Не пойму в чем ошибка.



///// 14. Найти третью цифру числа или сообщить, что её нет.

// Не корректно т.к. работает только для двузначных и трехзначных чисел.
// За третью цифру принимаю разряд сотен.

// int N = new Random().Next(10, 1000);
// System.Console.WriteLine(N);
// int a = N / 100;
// if (a != 0)
// {
//     System.Console.WriteLine(N / 100);
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }





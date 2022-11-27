// // Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Console.WriteLine("Введи первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b){
//     Console.WriteLine($"{a} больше {b}");        
// }
// else{
//     Console.WriteLine($"{b} больше {a}");
// }

// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введи первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (max < b)
// {
//     max = b;
// }
// if (max < c)
// {
//     max = c;
// }
// Console.WriteLine($"Максимальное число = {max}");



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введи число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n%2 == 0){
//     Console.WriteLine ($"{n} - четное");
// }
// else
// {
//     Console.WriteLine ($"{n} - не четное");
// }


// //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введи число n: ");
// int n = Convert.ToInt32(Console.ReadLine());;
// int i = 1;
// Console.WriteLine("четные числа, начиная с i");
// while (i <= n){
//     if (i%2 == 0)
//     {
//         Console.WriteLine($"{i}");
//     }
//     i++;
// }
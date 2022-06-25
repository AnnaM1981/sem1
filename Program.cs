// // 1 Напишите программу которая на вход принимает число и выдает его квадрат
// Console.WriteLine("input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is" + result);


// // 2 Напишите программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго
// Console.WriteLine("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 == square){
//    Console.WriteLine("first number is a square second number "); 
// }
// else{
//     Console.WriteLine("first number is not a square second number ");
// }

// // 3 Напишите программу которая будет выдавать день недели по заданному номеру.

// Console.WriteLine("input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7){
//     Console.WriteLine("incorrect day: ");
// }

// else{
//     if (day == 1) {
//        Console.WriteLine("monday"); 
//     }
//     if (day == 2) {
//        Console.WriteLine("tuesday"); 
//     }
//     if (day == 3) {
//        Console.WriteLine("wendsday"); 
//     }
//     if (day == 4) {
//        Console.WriteLine("thursday"); 
//     }
//     if (day == 5) {
//        Console.WriteLine("friday"); 
//     }
// }

// // Напишите программу, которая на вход принимает одно число N а на выходе выдает все целые числа.
// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0){
//   current = num;
//   num = num * (-1);
// }
//   else {
//       current = -1 * num;
//   }
   
// while (current < num-1){
//     current++;
//     Console.Write(current +" ");
    
// }
// 5 Напишите программу которая на входе принимает трехзначное число и на выходе показывает последнюю цифру
// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);

// Домашняя работа
//Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2){
//     Console.WriteLine ("num1 большее число, num2 меньшее число");
// }

// else

// {
//     Console.WriteLine ("num2 большее число, num1 меньшее число");
// }

// Задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("введите три числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b){
//     a = max;
// }
// else
// {
// b = max;
// }
// if (b > c){
//     Console.WriteLine ("max = b");
// }
// else 
// {
//     Console.WriteLine ("max = c");
// }
// if (c > a){
//     Console.WriteLine ("max = c");
// }

// else  
// {
//     Console.WriteLine ("max = a");
// }

// Задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0){
//     Console.WriteLine("четное число");
// }
// else {
//     Console.WriteLine("нечетное число");
// }
// Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num % 2 == 0){
// current = num;
// }
// else {
//     current = 1 + num;
// }
// while (current >= 1){
//     Console.WriteLine (current +"");
// }


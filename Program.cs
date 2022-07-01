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
// Console.WriteLine("input a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input c");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine (max);


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

// seminar 2
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

// void ShowNumber (){
//     int num = new Random ().Next(10, 100);
//     int firstNum = num / 10;
//     int secondNum = num % 10;
//     Console.Write(num + "->");
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine (secondNum);
//     }
// }

// ShowNumber();

// Задача 2. Напишите программу, которая выводит случайное 3-хзн. число и удаляет вторую цифру числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
  
//   int NumberWithoutSecDig(int Number){
//     int NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
//   }
//   int Number = new Random ().Next(100, 1000);
//   int a =  NumberWithoutSecDig (Number);
//   Console.WriteLine(a + " " + Number);

// Задача 3. Проверить кратность второго числа к первому.
// void MultiNum (int a, int b){
//     if (b%a == 0){
//         Console.WriteLine(b + " кратно " + a);
//     }
//     else{
//         Console.WriteLine(b + " некратно " + a + ", остаток " + b%a);
//     }
// }
// Console.Write("Введите последовательно два числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// MultiNum(num1, num2);

// Задача 4. Написать программу, которая принимает на вход число и проверяет кратно ли оно.

// void NumDiv(int a){
//     if(a%7 == 0 && a%23 == 0){
//         Console.WriteLine(a + " кратно 23 и 7 ");
//     }
//     else{
//         Console.WriteLine(a + "не кратно 23 и 7 ");
//     }
// }
// Console.Write("Введите число:");
// NumDiv(Convert.ToInt32(Console.ReadLine()));

// Семинар 3

// Задача 1. Напишите программу которая принимает на вход координаты точки (х,у) причем х не равен 0, у не равен 0,
// и выдает номер четверти плоскости, в которой находится эта точка.
// void getDot (int x, int y) {
//     if (x == 0 || y ==0){
//         Console.WriteLine ("нет возможности определить четверть");
//     }
//     else{
//         if (x > 0 && y > 0)
//             Console.WriteLine ("1 четверть");
        
//         if (x < 0 && y > 0)
//             Console.WriteLine ("2 четверть");
        
//         if (x < 0 && y < 0)
//             Console.WriteLine ("3 четверть");
        
//         if (x > 0 && y < 0)
//             Console.WriteLine ("4 четверть");
//      }
// }
// Console.WriteLine ("введите координаты точки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// getDot (x,y);

// Задача 2. Напишите программу которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти х и у.
// void getDot (int num){
//     if (num < 1 || num > 4){
//         Console.WriteLine ("нет возможности определить диапазон координат");
//     }
//     else{
//         if (num == 1)
//             Console.WriteLine ("x > 0 && y > 0");
        
//         if (num == 2)
//             Console.WriteLine ("x < 0 && y > 0");
        
//         if (num == 3)
//             Console.WriteLine ("x < 0 && y < 0");
        
//         if (num == 4)
//             Console.WriteLine ("x > 0 && y < 0");
//      }
// }
// Console.WriteLine ("введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// getDot (num);

// Задача 3. Напишите программу которая принимает на вход координаты двух точек и находит пространство между ними в 2Д пространстве.
// А (3,6); В (2,1) -> 5,09
// A (7,-5); B (1,-1) ->7,21
// Console.Clear();
// double Dist(int x1, int y1, int x2, int y2){
//     return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
// }
// Console.WriteLine("Введите координаты х1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Длина отрезка: " + Dist(xA, yA, xB, yB));

// Задача 4. Напишите программу которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4
// void listSqrt(int N){
//     int count = 1;
//     Console.Write (N + "-> ");

//     if(N > 0)
//     {

//         while (count <= N)
//         {
//         Console.Write (Math.Pow(count, 2) + ", ");
//         count ++;
//         }
//     }
//     else 
//     {
//     count = -1;
//     while (count >= N)
//         {
//         Console.Write (Math.Pow(count, 2) + ", ");
//         count --;
//         }
//     }
// }
// Console.WriteLine ("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// listSqrt(num);

// Семинар 4
// Задача 1. Напишите программу которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7->28
// 4->10
// 8->36

// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));

// Задача 2. Напишите программу которая принимает на вход число и выдает количество цифр в числе.
// 456->3
// 78->2
// 89126->5
// int CountNumber(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count ++;
//     }
//     return (count);
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumber(number));

// Задача 3. Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N.

// int MultiToNum(int num)
// {
//     int multiplay = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         multiplay *= i;
//     }
//     return multiplay;
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Multiplay of elements is " + MultiToNum(number));

// Задача 4. Напишите программу которая выводит массив из 8 элементов заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Создаем массив случайных чисел, где size - количество элементов в массиве, min - начало диапазона случайных чисел, max - до какого генеририруем.
// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// создаем массив из чисел которые вводим
// int[] CreateArray(int size){

//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         Console.Write("Input " + i + "element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// выводим массив на экран значения массива в одну строку через пробел
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }
// int[] myRandomArray = CreateRandomArray (6);
// ShowArray(myRandomArray);
// Console.WriteLine();

// Домашняя работа (семинар 4)

// Задача № 3. Напишите программу которая задает массив из 8 элементов и выводит их на экран.

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         Console.Write("Input " + i + "element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }
// int[] myRandomArray = CreateArray (8);
// ShowArray(myRandomArray);
// Console.WriteLine();

// Задача № 2. Напишите программу которая принимает на вход число и выдает сумму цифр в числе.

//  int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = num / 10; num > 0; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));

// Семинар 5.
// Примеры форматирования (интерполяция)
// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0} Возраст: {1}", name, age);

// Форматирование дробного числа (f - количество символов после запятой)
// double number = 45.08;
// string result = string.Format("{0:f1}",number);
// Console.WriteLine(result);

// Форматирование с математическими действиями
// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// Форматирование с пробелами
// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); //пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); //пробелы до

// Задача 1.
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найти сумму отрицательных и положительных элементов массива.
// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];

// } 
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.
// [-4,-8,8,2]->[4,8,-8,-2]

// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(-100,101);
//     }
//     return array;
//     }

// int[] GetArray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1); //как 1 вариант
//         array[i]*=-1;              //как 2 вариант
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] array = CreateRandomArray(4);
// ShowArray(array);
// Console.WriteLine();
// ShowArray(GetArray(array));


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заднное число в массиве.
// 4; [6,7,19,345,3] -> нет
// -3; [6,7,19,345,3] -> да
// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,100);
//     }
//     return array;
//     }
// int[] MyArray = CreateRandomArray(8);

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// ShowArray(MyArray);

// int ArrayCheck(int[] array)
// {
// for (int i = 0; i < MyArray.Length; i++)
//     {
//     if (MyArray[i] == 4)
//         {
//         return 1;
//         }
//     }
//     return 0;
// }
//     if (ArrayCheck(MyArray) ==1)
//     {
//         Console.WriteLine(" Number is present");
//     }
//     else
//     {
//         Console.WriteLine(" Number is not present");
//     }
    
// Домашняя работа (семинар 5)

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] RandomArray(int size)
// {
//     int[] array = new int(size);
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[]MyArray = RandomArray(6);
// ShowArray (MyArray);

// void SumOddPositionsInArray (int[]array)
// {
//     int result = 0;

//     for (int i = 1; i < array.Length; i= i + 2)
//     {
//         result = result + array[i];
//     }
//     Console.WriteLine("The sum is " + result);
// }
// SumOddPositionsInArray (MyArray);

// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] RandomArray(int size)
// {
//     int[] array = new int(size);
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     }
// }
// int[] MyArray = RandomArray(10);
// ShowArray(MyArray);

// void EvenNumberInArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 ==0)
//         count++;
//     }
//     Console.WriteLine("Even number count is " + count);
// }
// EvenNumberInArray(MyArray);

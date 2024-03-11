// Задание 1

// Console.Clear();
// Console.Write("Введите число a: "!);
// int a = int.Parse(Console.ReadLine()!);
// if (a % 7 == 0 && a % 23 == 0){
//     Console.WriteLine("Да");
// }
// else {
//     Console.WriteLine("Нет");
// }

// Задание 2

// Console.Clear();
// Console.Write("Введите x: "!);
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y: "!);
// int y = int.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0){
//     Console.WriteLine("1 координатная четверть");
// }
// else
// if (x > 0 && y < 0){
//     Console.WriteLine("2 координатная четверть");
// }
// else
// if (x < 0 && y < 0){
//     Console.WriteLine("3 координатная четверть");
// }
// else
// if (x < 0 && y > 0){
//     Console.WriteLine("4 координатная четверть");
// }

// Задание 3

// Console.Clear();
// Console.Write("Введите число из отрезка [10, 99]: "!);
// int number = int.Parse(Console.ReadLine()!);
// while (number < 10 || number > 99){
// Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
// number = int.Parse(Console.ReadLine()!);
// }
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber){
//     int max = firstNumber;
//     Console.WriteLine(max);
// }
// else 
// if (firstNumber < secondNumber){
//     int max = secondNumber;
//     Console.WriteLine(max);
// }

// Задание 4

Console.Clear();
Console.Write("Введите число N: "!);
int N = int.Parse(Console.ReadLine()!);
if (N < 10){
    Console.WriteLine(N);
}
else {
while (N > 0){
int N1 = N % 10;
N /= 10;
if (N > 0){
    Console.Write(N1 + ",");
}
else{
    Console.WriteLine(N1);

}
}
}
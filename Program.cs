//\\ Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введите трехзначное число, чтобы вывести его вторую цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num>=100 && num<=999)
// {
// int a=num/10%10;
//     Console.WriteLine("Вторая цифра: " +a);  
// }
// else
// {
//     Console.WriteLine("неверное число ");
//     }


//\\ Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.Write("Введите  число, чтобы вывести третью цифру заданного числа: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(num) < 100)
// {
//     Console.WriteLine("Третьей цифры нет ");
// }
// else
// {
//     while (Math.Abs(num) > 999)
//         num = num / 10;
//     Console.WriteLine("третья цифра " + num % 10);
// }



//\\ Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите  число дня недели, чтобы понять выходной это или нет: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num>7)||(num<1))
{
    Console.WriteLine("Неправильный день недели ");
}
if (num>5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}
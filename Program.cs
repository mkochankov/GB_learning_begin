// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.


Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<100)
{
    Console.WriteLine("Нет третьей цифры");
} 
else 
{
    string num = Convert.ToString(number);
    Console.WriteLine(num.ToString()[2]);
}
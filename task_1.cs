// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num
int rev = 0
while (num > 0)
    {
        dig = num % 10;
        rev = rev * 10 + dig;
        num /= 10;
    }
if (temp == rev)
{
    Console.WriteLine($"Ваше число: {num} является палиндромом.");
}
esle
{
    Console.WriteLine($"Ваше число: {num} не является палиндромом.");
}
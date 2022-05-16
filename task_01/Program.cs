// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введи 5-ти значное число - ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");
bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}
if (IsPalindrome()) Console.WriteLine($"{number} - палиндром");
else Console.WriteLine($"{number} - не палиндром");
Console.WriteLine();

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int chislo = 0;
int vvedennoeChiclo = 0;

// Проверка на пятизначность:
while (chislo < 10000 || chislo > 99999)
{
    Console.Write("Введи пятизначное число: ");
    chislo = Convert.ToInt32(Console.ReadLine());
    vvedennoeChiclo = chislo;
    if (chislo < 0) chislo = chislo * (-1);
    if (chislo < 10000 || chislo > 99999) Console.WriteLine("Введено НЕ пятизначное число. Попробуй ещё раз.");
}

//Вычисление 1,2,4,5-й цифры чила:
int chislo_1 = chislo / 10000;
int chislo_2 = chislo / 1000 % 10;
int chislo_4 = chislo / 10 % 10;
int chislo_5 = chislo % 10;

if ((chislo_1 == chislo_5) && (chislo_2 == chislo_4))
{
    Console.WriteLine($"Введённое число {vvedennoeChiclo} является палиндромом.");
}
else
{
    Console.WriteLine($"Введённое число {vvedennoeChiclo} НЕ является палиндромом.");
}
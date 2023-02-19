// Доп. задание №2:
// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре. 
// Напишите программу, которая определяет интересное число или нет. 
// Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)


int max = 0;
int max1 = 0;
int imax = 0;
int min = 10;
int min1 = 10;
int imin = 10;
int raznost = 0;
int count = 0;
int nextcount = 10;
int i = 10;
int nextDigit = 0;
int newchislo = 0;
int srednee =0;

Console.Clear();

Console.Write("Введи число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

count = countOfChislo(chislo);

// Находим max и min:
for(i = 0; i < count; i++)
{
    nextDigit = (chislo /Convert.ToInt32(Math.Pow(10, i))) % 10;
    if (max < nextDigit)  
    {
        max = nextDigit;
        imax = i+1;
    }
    if (min > nextDigit)  
    {
        min = nextDigit;
        imin = i+1;
    }
}

// удаляем max и min из числа, пока не останется не более 2-х цифр:
newchislo = chislo;
while (nextcount > 2)
{
    if (imax > imin )
    {
        newchislo = newchislo /Convert.ToInt32(Math.Pow(10, imax)) * Convert.ToInt32(Math.Pow(10, imax-1)) + newchislo % Convert.ToInt32(Math.Pow(10, imax-1)) ;
        newchislo = newchislo /Convert.ToInt32(Math.Pow(10, imin)) * Convert.ToInt32(Math.Pow(10, imin-1)) + newchislo % Convert.ToInt32(Math.Pow(10, imin-1)) ;
    }
    else
    {
        newchislo = newchislo /Convert.ToInt32(Math.Pow(10, imin)) * Convert.ToInt32(Math.Pow(10, imin-1)) + newchislo % Convert.ToInt32(Math.Pow(10, imin-1)) ;
        newchislo = newchislo /Convert.ToInt32(Math.Pow(10, imax)) * Convert.ToInt32(Math.Pow(10, imax-1)) + newchislo % Convert.ToInt32(Math.Pow(10, imax-1)) ;
    }
    nextcount = countOfChislo(newchislo);

    // Находим max и min:
    imax = 0;
    imin = 0;
    max1 = 0;
    min1 = 10;
    for(i = 0; i < nextcount; i++)
    {
        nextDigit = (newchislo /Convert.ToInt32(Math.Pow(10, i))) % 10;
        if (max1 < nextDigit)  
        {
            max1 = nextDigit;
            imax = i+1;
        }
        if (min1 > nextDigit)  
        {
            min1 = nextDigit;
            imin = i+1;
        }
    }
}

srednee = max1;
raznost = max - min;

// Сравниваем среднее число с разностью max и min 
if (srednee == raznost)  Console.WriteLine("Число интересное.");
else Console.WriteLine("Число НЕ интересное.");

Console.WriteLine($"max:{max}, min:{min}, разность:{raznost}");





// Находим count:
int countOfChislo(int chislo1)
{
    int countTemp = 0;
    int rezultTemp = 1;
    int i = 10;
    while (rezultTemp > 0)
    {
        rezultTemp = chislo1 / i;
        i = i * 10;
        countTemp ++;
    }

    return countTemp;
}
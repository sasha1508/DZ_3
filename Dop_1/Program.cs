// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
// На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
// Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.Clear();

Console.Write("Введите сумму вклада: ");
string summaVklada = "";
string summaVklada1 = "";

summaVklada = Console.ReadLine();

// Преобразуем строку с точкой в строку с запятой:
var count = summaVklada.Length;
for(int i = 0; i < count; i++)
{
    if (summaVklada[i].CompareTo('.') == 0)     summaVklada1 = summaVklada1 + ",";
    else summaVklada1 = summaVklada1 + summaVklada[i];
}

double chislo = Convert.ToDouble(summaVklada1);
double result =  0;
double procent = 0;

if (chislo < 0) chislo = chislo * (-1);

if (chislo < 100)    
{
    result = Math.Round(chislo * 1.05, 2);
    procent = 5;
}
else if (chislo >= 100 && chislo < 200)  
{
    result = Math.Round(chislo * 1.07, 2);
    procent = 7;
}
else 
{
    result = Math.Round(chislo * 1.1, 2);
    procent = 10;
}

Console.WriteLine($"Итоговая сумма с учётом {procent}% составит: {result}.");
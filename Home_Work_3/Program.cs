/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
//рандомное заполнение массива и печать в консоль
void FillTable(ref int[,] table)
{
    int indexLine = 0;
    while (indexLine < table.GetLength(0))
    {
        for (int indexPost = 0; indexPost < table.GetLength(1); indexPost++)
        {
            table[indexLine, indexPost] = new Random().Next(-100, 100);
            Console.Write($"{table[indexLine, indexPost]} | ");
        }
        Console.WriteLine();
        indexLine++;
    }
}
//поиск среднего арифм.
void SearchMean(int[,] table)
{
    double mean = 0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            mean += table[i, j];
        }
        mean = mean / table.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {j+1} будет {mean}");
        mean = 0;
    }

}

//основной код
Console.Clear();
int[,] table = new int[5, 5];
FillTable(ref table);
SearchMean(table);
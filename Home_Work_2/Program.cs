/*Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Вы ввели значение меньше допустимого. Пожалуйста введите корректное значение.");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//рандомное заполнение массива и печать в консоль
void FillTable(double[,] table)
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
//проверка эллемента и его вывод
void ElementTable(double[,] table, int line, int post)
{
    if (line < table.GetLength(0) && post < table.GetLength(1))
    {
        Console.WriteLine(table[line, post]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует в данном массиве!");
    }

}
//основной код
int line = InputControl("Введите строку искомого элемента:");
int post = InputControl("Введите столбец искомого значения:");
int i = new Random().Next(1, 20);
int j = new Random().Next(1, 20);
double[,] arrayTable = new double[i, j];
FillTable(arrayTable);
ElementTable(arrayTable, line, post);

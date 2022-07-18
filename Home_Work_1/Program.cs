/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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
    double random = 0;
    int indexLine = 0;
    while (indexLine < table.GetLength(0))
    {
        for (int indexPost = 0; indexPost < table.GetLength(1); indexPost++)
        {
            random = new Random().NextDouble();
            table[indexLine, indexPost] = new Random().Next(0, 10);
            table[indexLine, indexPost] = table[indexLine, indexPost] * random;
            Console.Write($"{table[indexLine, indexPost]} | ");
        }
        Console.WriteLine();
        indexLine++;
    }
}
//основной код
int line = InputControl("Введите количество строк: ");
int post = InputControl("Введите количество столбцов: ");
double[,] arrayTable = new double[line, post];
FillTable(arrayTable);
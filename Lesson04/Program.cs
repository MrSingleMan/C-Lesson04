int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int [rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(10, 99);
    }
}
return matrix;
}

void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
}
int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);

//Создать функцию, которая выводит чётные числа из двумерного массива
void IntrestedNumber (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    if (matrix[i,j] % 2 ==0)
    {
    Console.Write($"{matrix[i,j]} ");
    }
    }
}
}
IntrestedNumber(matrix);

//Считать с консоли строку, состоящую из цифр и латинских букв.
//Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromString(string s)
{
    string Letters = " ";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            Letters = Letters + e;
        }
    }
    return Letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);

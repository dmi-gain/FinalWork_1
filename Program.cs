/*

Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] => ["2", ":-)"]
["1234", "1567", "-2", "computer science"] => ["-2"] 
["Russia", "Denmark", "Kazan"] => []

*/

string[] arrayCome_1 = { "hello", "2", "world", ":-)" };
int countElements_1 = CalcLengthString(arrayCome_1);
string[] resultArray_1 = FillResultArray(arrayCome_1, countElements_1);


string[] arrayCome_2 = { "1234", "1567", "-2", "computer science" };
int countElements_2 = CalcLengthString(arrayCome_2);
string[] resultArray_2 = FillResultArray(arrayCome_2, countElements_2);

string[] arrayCome_3 = { "Russia", "Denmark", "Kazan" };
int countElements_3 = CalcLengthString(arrayCome_3);
string[] resultArray_3 = FillResultArray(arrayCome_3, countElements_3);


int CalcLengthString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FillResultArray(string[] array, int count)

{
    string[] result = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            result[result.Length - count] = array[j];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]} ");
    }
    System.Console.WriteLine();
}

PrintArray(resultArray_1);
PrintArray(resultArray_2);
PrintArray(resultArray_3);
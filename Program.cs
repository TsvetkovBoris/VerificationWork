/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] MyArray(int size)
{
    string[] arrString;
    arrString = new string[size];
    Console.WriteLine("Введите массив:");
    for(int i = 0; i < arrString.Length; i++)
        arrString[i] = Console.ReadLine()!;
    return arrString;
}

string[] NewMyArray(string[] arrStr, int size)
{
    int j = 0;
    string[] NewStr;
    string[] NewStr1;
    NewStr = new string[size];
    Console.WriteLine("Новый массив: ");
    for(int i = 0; i < size; i++)
    {
        if(arrStr[i].Length < 4)
        {
            NewStr[j] = arrStr[i];
            j++;
        }
    }
    NewStr1 = new string[j];
    for(int i = 0; i < j; i++)
        Console.Write(NewStr[i] + " ");
    return NewStr;
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] MyArr = MyArray(size);
string[] newMyArr = NewMyArray(MyArr, size);
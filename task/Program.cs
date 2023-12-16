int length = Prompt ("Введите количество элементов массива : ");
int numbsymbol = Prompt ("Введите предельное количество символов : ");
string[] stringarray;
stringarray = FillArray(length);
PrintArray(stringarray);
Console.WriteLine();
PrintFinalArray(stringarray, numbsymbol);

int Prompt(string message)
{
    System.Console.Write(message); // вывести сообщение
    string value =Console.ReadLine(); // считывает с консоли строку
    int result = Convert.ToInt32(value); // преобразует строку в целое число
    return result;
}

string[] FillArray (int length)
{
    string[] stringarray = new string[length];
    for(int i = 0; i < stringarray.Length; i++)
        {
        Console.WriteLine($"Введите элемент массива под индексом {i}:");
        stringarray[i] = Console.ReadLine();
        }
    return stringarray;
}

void PrintArray (string[] array)
{
    Console.WriteLine("Массив элементов:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + "  ");
    }
   
}

void PrintFinalArray (string[] array, int numb)
{
    Console.WriteLine($"Элементы, длина которых меньше, либо равна {numb} символам :");
    string[] finalarray=new string[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= numb && array[i].Length > 0)
        {
        finalarray[i]=array[i];
        Console.Write($"{finalarray[i]}" + "  "); 
        }
               
     }
}
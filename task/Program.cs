int length = Prompt ("Введите количество элементов массива : ");
int numbsymbol = Prompt ("Введите предельное количество символов : ");
string[] stringarray;
stringarray = FillArray(length);

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

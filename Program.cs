string[] GenerateArray()
{
    Console.WriteLine("Введите элементы массива через ,");
    string input = Console.ReadLine();
    string[] array = input.Split(",");
    return array;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void FilterThreeSymbolElements(string[] array)
{
    int Array2Length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        if (element.Length < 4)
        {
            Array2Length++;
        }
    }
    if (Array2Length == 0)
    {
        Console.WriteLine("Элементы длиной менее 4 символов отсутствуют");
    }
    else
    {
        string[] array2 = new string[Array2Length];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            string element = array[i];
            if (element.Length < 4)
            {
                array2[j] = array[i];
                j++;
            }
        }


        Console.WriteLine("Элементы, длина которых меньше или равна 3 символам:");
        PrintArray(array2);
    }
}
Console.WriteLine();
string[] array = GenerateArray();
FilterThreeSymbolElements(array);

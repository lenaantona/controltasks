// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Write("Введие массив через точку c запятой: ");
string [] newarr = Console.ReadLine().Split(';');
Console.WriteLine("Начальный массив: [" + string.Join(", ", newarr) + "]");
string [] ArraysCharThree(string [] arrays)
{
    int j = 0;
    int count = 0;
    for (int i = 0; i < arrays.Length; i++)
    {
        if (arrays[i].Length <= 3) count++;
    }
    string [] arrrayresult = new string [count];
    for (int i = 0; i < arrays.Length; i++)
    {
        if (arrays[i].Length <= 3) 
        {
            arrrayresult[j] = arrays[i];
            j++;
        }
    }
    return arrrayresult;
}
string [] ArraysRes = ArraysCharThree(newarr);
Console.WriteLine("Итоговый массив [" + string.Join(", ", ArraysRes) + "]");
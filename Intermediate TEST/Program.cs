//метод формирует массив строк не более чем из 3х символов
string[] ShortElemArray(string[] arr)
{
    //определение длины нового массива со строками <= 3 символам
    int newLength = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newLength++;
        }
    }

    string[] newArr = new string[newLength]; //создание нового массива с новой длиной
    int count = 0; //счётчик элементов нового массива
    for (int j = 0; j < arr.Length; j++) //проходим по каждому элементу исходного массива
    {
        if (arr[j].Length <= 3)
        {
            newArr[count] = arr[j]; //если символов 3 и меньше, записываем строку в новый массив
            count++;
        }
    }
    return newArr; //возвращаем новый массив
}

//печать одномерного массива
void Print1DArray(string[] array)
{
    Console.Write("[");
    if (array.Length > 1)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1] + "]");
    }
    if (array.Length == 1)
    {
        Console.WriteLine(array[0] + "]");
    }
    if (array.Length == 0)
    {
        Console.WriteLine("]");
    }
}

//печать текста
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Computer", "Desktop", "Laptop" };
// string[] array = { "1234", "1567", "-2", "computer science", "So", "far", "Lamp", "car", "cat"};
PrintResult("Исходный массив: ");
Print1DArray(array);
string[] shortArray1 = ShortElemArray(array);
PrintResult("Новый массив со строками, состоящими из 3 и менее символов: ");
Print1DArray(shortArray1);
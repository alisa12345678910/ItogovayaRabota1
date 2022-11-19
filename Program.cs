// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


// Поиск значения менее трех символов
string[] LessThanNumber(string[] input, int n) 
{
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

// 
int CountLessThan(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

// Ввод значений для массива
string[] FillArray() 
{
    Console.Write("Введите значения массива через пробел: ");
    return Console.ReadLine()!.Split(" ");
}

string[] array = FillArray();
string[] result = LessThanNumber(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

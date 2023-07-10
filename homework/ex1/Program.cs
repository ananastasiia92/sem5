//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetRandomArray(3, 100, 999);
Console.WriteLine($"{String.Join("; ", array)}");
Console.WriteLine($"Количество чётных чисел в массиве -> {FindQuantyElement(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int FindQuantyElement(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0){
        count++;
    }
    return count;
}
    

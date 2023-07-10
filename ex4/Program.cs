/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5
*/
Console.Clear();
int[] array = GetRandomArray(123, 1, 999);
Console.WriteLine($"{String.Join("; ", array)}");
Console.WriteLine($"Количество элементов в отрезке [10;99] = {FindNum(array, 10, 99)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int FindNum(int[] array, int leftRange, int rigthRange)//[1,2,3,4] 5
{
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if (i >= leftRange && rigthRange > i){
        count++;
    }
    /*int count = 0;
    foreach (int i in array)
    {
        if (i >= leftRange && i <= rigthRange) count++;
    }*/
    
    }return count;

}


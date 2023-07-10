/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
int[] array = GetRandomArray(4, -9, 9);
Console.WriteLine($"{String.Join("; ", array)}");

Console.WriteLine($"{String.Join("; ", ReplacePos(array))}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] ReplacePos(int[] array){// [1, -2, 3, -4, 5] ->[-1,2,-3,4,-5]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

/* **Задача 32:**Напишите программу замена элементов маccива: 
положительные элементы замените на моответѝтвующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)
Console.Clear();
PrintAns(CreatArr());

int[] CreatArr(){
int n = new Random().Next(2, 10);
int[] arr = new int[n];
for(int i = 0;i < arr.Length;i++){
arr[i] = new Random().Next(-10, 10);
}
return arr;
}

void PrintAns(int[] array){
Console.Write("[");
for(int i = 0;i < array.Length - 1;i++){
Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length - 1] }] -> [");

for(int i = 0;i < array.Length - 1;i++){
Console.Write($"{-array[i]}, ");
}
Console.Write($"{-array[array.Length - 1] }]");
}
*/
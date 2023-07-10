//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] array = GetArrayFromString(elements);
int diff = GetDiff(array);
Console.WriteLine($"{diff}");


int[] GetArrayFromString(string array)
{
    string[] nums = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int GetDiff(int[] array){
    int min = array[0];
    int max = array[0];
    
    for(int i = 1; i < array.Length; i++){
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    return max-min;
}

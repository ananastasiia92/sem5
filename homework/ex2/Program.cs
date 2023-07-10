// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] array = GetArrayFromString(elements);
int r = SumOddIndex(array);
Console.WriteLine($"{r}");


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

int SumOddIndex(int[] array){
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }return sum;
}

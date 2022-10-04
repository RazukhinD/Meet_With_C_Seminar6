using static System.Console;
Clear();

Write("Введите какие-то  числа через пробел: ");
string[] numbers = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int res = HowManyPositiveNumbers(numbers);
WriteLine($"Количество элементов больше 0 = {res}");







int HowManyPositiveNumbers(string[] array)
{
    int result = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (Convert.ToInt32(array[i])>0) result++;
    }
    return result;
}

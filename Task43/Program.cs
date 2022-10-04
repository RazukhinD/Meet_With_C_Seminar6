using static System.Console;
Clear();

Write("Введите через пробел или через запятую b1, k1, b2, k2: ");
string[] numbers = ReadLine()!.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
double[] koef = ConvertToIntstring(numbers);
if (koef[1]==koef[3]) WriteLine("Задайте другие k1 и k2");
double x = (koef[2]-koef[0])/(koef[1]-koef[3]);
double y = koef[1]*x+koef[0];
WriteLine($"Точкой пересечения двух прямых {koef[1]}*x+{koef[0]} и {koef[3]}*x+{koef[2]} является точка с координатой х={x}, y={y}");








double[] ConvertToIntstring(string[] array)
{
    double[] result = new double[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        result[i]=Convert.ToInt32(array[i]); 
    }
    return result;
}

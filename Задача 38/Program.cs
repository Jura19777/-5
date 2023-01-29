//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] myArray = new double[12];
Random rand = new Random();
Console.Clear();
double max = 0, min = 1000000;
string otvet ="";

for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.NextDouble()*100;
}

foreach (float x in myArray)
{
    otvet = otvet + x.ToString() + "  ";
    if (x>max) 
        max = x;
    if (x<min) 
        min = x;
}
Console.Write($"[{otvet.Substring(0, otvet.Length - 2)}] -> {max-min}");
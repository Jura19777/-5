// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] myArray = new int[10];
Random rand = new Random();
Console.Clear();
int chet = 0;
string otvet ="";

for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.Next(100, 1000);
}

foreach (int x in myArray)
{
    otvet = otvet + x.ToString() + ",  ";
    if (x%2==0)
    {
        chet++;
    }
}
Console.Write($"[{otvet.Substring(0, otvet.Length - 2)}] -> {chet}");
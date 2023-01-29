//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. 
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] myArray = new int[12];
Random rand = new Random();
Console.Clear();
int sum = 0;
string otvet ="";

for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.Next(-100, 100);
}

for (int x = 0; x < myArray.Length; x++)
{
    otvet = otvet + myArray[x].ToString() + ",  ";
    if (x%2>0)
    {
        sum = sum + myArray[x];
    }
}
Console.Write($"[{otvet.Substring(0, otvet.Length - 2)}] -> {sum}");
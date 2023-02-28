//найти разницу между максимальным и минимальным элементами в случайном массиве
Console.WriteLine("Введите кол-во элементов в массиве:");
int numbermas = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[numbermas];
Random rnd = new Random();
for (int count = 0; count < numbermas; count++)
{
    mas[count] = rnd.Next(0, 100);
    //Console.WriteLine("Элемент массива номер " + count + " = " + mas[count]);
}
int min = mas[0];
int max = mas[0];
for (int count = 1; count < numbermas; count++)
{
    if (mas[count] > max)
    {
        max = mas[count];
    }    
    else if (mas[count] < min)
    {
        min = mas[count];
    }
}
//Console.WriteLine("Минимальный элемент массива = " + min);
//Console.WriteLine("Максимальный элемент массива = " + max);
double cht = max - min;
Console.WriteLine("Разница максимального и минимального элементов массива = " + cht);
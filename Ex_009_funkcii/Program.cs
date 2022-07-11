/*int Max(int num1, int num2, int num3)
{
    int resalt = num1;
    if (num2 > resalt) resalt = num2;
    if (num3 > resalt) resalt = num3;
    return resalt;
}
*/
/*
int a1 = 58, a2 = 344, a3 = 56;
int b1 = 582, b2 = 44, b3 = 50;
int c1 = 245, c2 = 335, c3 = 996;
int max = Max(Max(a1,a2,a3),Max(b1,b2,b3),Max(c1,c2,c3));
Console.WriteLine(max);
*/
/*
int[] nam = {123,3434,545,24,354,342,45,6,67};
int max = Max(Max(nam[0],nam[1],nam[2]),Max(nam[3],nam[4],nam[5]),Max(nam[6],nam[7],nam[8]));
Console.WriteLine(max);
*/
/*
int[] array = { 55, 23, 43, 54, 65, 76, 87, 12, 43, 45, 65565, 767, 43, 24323, 23, 45 };
int find = 45, index = 0;
while (index < array.Length)
{
    if (array[index] == find)
    {
        Console.WriteLine(array[index] + " - " + index);
        break;
    }
    index++;
}
*/

void FullArray(int[] mass)
{
    int index = 0;
    while (index < mass.Length)
    {
        mass[index] = new Random().Next(1, 9);
        index++;
    }
}
void WriteArray(int[] mass)
{
    int index = 0;
    while (mass.Length > index)
    {
        Console.WriteLine(mass[index]);
        index++;
    }
}
int Max(int[] mass, int find)
{
    int count = 0;
    int res = -1;
    while (count < mass.Length)
    {
        if (mass[count] == find)
        {
        res = count;
        break;
        }
        count++;
    }
    return res;
}
int[] array = new int[10];
FullArray(array);
WriteArray(array);
Console.Write("Загодай число : ");
int fi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Max(array,fi));
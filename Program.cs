// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int Rekursia(int valeu)
{
    int rez = 0;
    while (valeu > 0)
    {
        rez = valeu / 2 % 2;
    }
    return rez;
}

int rut = Rekursia(101101);
Console.WriteLine(rut);



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.Не использовать Math.Pow() и аналоги!

int NaturalStepenB(int a, int b)
{
    int temp =0;
    for (int i =0, j =0; i<=a && j<=b; j++, i++)
    {
        if (i % 2==0) temp = j*(i* i* i);
        else
        {temp = j*(i* i* i* i);}
    }
    return temp;
}
int rev = NaturalStepenB(5, 6);



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ChisloPlusNaMinus(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int rev = array[i];
        array[i] = rev * -1;
    }
    return array;
}
int[] array = {1,2,3,4,-8,-9,-6};
int[] rez = ChisloPlusNaMinus(array);




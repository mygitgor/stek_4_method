// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int KolicesCifertvoChisle(int number)
{
  int count=0;
   while(number>0)
   {
      number /= 10;
      count++;
   }
   return count;
}



// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А



int SummOnToN(int number)
{
  int sum=0;
   for (int i = 1; i <= number; i++)
   {
    sum += i;
   }
   return sum;
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SummaVchisle(int valeue)
{ 
    int sum = 0;
    while (valeue > 0)
    {
        sum = sum + valeue % 10;
        valeue = valeue /10;

    }
    return sum;
}



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

    
        
int Fact(int n){

    int fact =1;
     for (int i=1; i<=n; i++)
     if (i>0)
     {
       fact=fact*i;
     }
     return fact;   
}



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;

}

int[] rand = GetRandomArray(12, 0, 1);
System.Console.WriteLine(string.Join(" ,",rand));




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




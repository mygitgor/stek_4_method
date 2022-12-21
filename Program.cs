
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



int NaturalStepenB(int a, int b)
{
    int temp = 0;
    for (int i = 0, j = 0; i <= a && j <= b; j++, i++)
    {
        if (i % 2 == 0) temp = j * (i * i * i);
        else
        { temp = j * (i * i * i * i); }
    }
    return temp;
}
int rev = NaturalStepenB(5, 6);


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
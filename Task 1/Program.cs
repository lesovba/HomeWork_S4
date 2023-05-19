int[] Prompt()
{
    Console.WriteLine("Введите число A: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int power = int.Parse(Console.ReadLine());
    int[] pair = {number, power}; 
    return pair;     
}

int GetExponent(int[] array)
{
    int result = 1; 
    for (int i=1; i<=array[1]; i++)
    result*=array[0];
    return result; 
}

Console.WriteLine("А в степени B равно: " + GetExponent(Prompt()));
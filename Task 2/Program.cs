int Prompt()
{
    Console.WriteLine("Введите число : ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void GetDigitSum (int number)
{
    int sum = 0; 

    while (number != 0)
    {
        sum = sum + (number%10); 
        number =  number/10; 
    }
    Console.WriteLine(sum);
}

GetDigitSum(Prompt()); 
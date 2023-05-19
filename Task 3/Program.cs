int[] FillArray ()
{
    Console.WriteLine("Введите длину массива");
    int arrLength = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите {arrLength} элементов массива");
    int[] array = new int[8];    
    for (int i = 0; i<8; i++) 
    {
    Console.WriteLine($"Введите {i} элемент массива:");
    array[i] = int.Parse(Console.ReadLine());
    }
    return(array); 
}

void PrintArray(int[] arr)
{
    for (int i = 0; i<arr.Length-1; i++){
    Console.Write($" {arr[i]}, ");} 
    // Убираем запятую после последнего элемента в консоли
    Console.Write($" {arr[7]} ");
    Console.WriteLine(); 
}

PrintArray(FillArray());
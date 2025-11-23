int[] numbers = [1, 17, 10, 3, 11, 26, 72, 33];
int[] newNumbers = new int[8];
int evenCount = 0;
int oddCount = 0;

// will make numbers even if odd and odd if even by increasing for odds and decreasing for evens

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
        Console.WriteLine($"The number {numbers[i]} is even. \n");
        newNumbers[i] = numbers[i] - 1;
    }
    else
    {
        oddCount++;
        Console.WriteLine($"The number {numbers[i]} is odd. \n");
        newNumbers[i] = numbers[i] + 1;
    }
}

Console.WriteLine($"There were a total of {evenCount} evens and {oddCount} odds in the numbers array. \n");
Console.WriteLine($"This is the original array: {string.Join(" , ", numbers)}");
Console.WriteLine($"This is the new array: {string.Join(" , ", newNumbers)}");

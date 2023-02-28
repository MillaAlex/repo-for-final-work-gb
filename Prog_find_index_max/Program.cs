// Program for search of index of the max value in array

int[] numbers = new int[6] {1, 8, 3, 9, 12, 16};

int currentIndex = 0;
int maxNumberIndex = 0;

int max = numbers[0];

while (currentIndex < numbers.Length)
{
    if (numbers[currentIndex] > max) 
    {
        max = numbers[currentIndex];
        maxNumberIndex = currentIndex;
    }
    else currentIndex++;
}
Console.Write($"Index of max value is {maxNumberIndex}; max value is {max}");
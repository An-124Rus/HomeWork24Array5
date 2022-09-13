internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 10;
        int firstNumbersCount = 0;
        int secondNumbersCount = 0;

        Random randome = new Random();

        Console.Write("Введите длину массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randome.Next(minValue, maxValue);

            Console.Write(array[i] + " ");
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                firstNumbersCount++;
            }
            else if (array[i] != array[i - 1] && firstNumbersCount > secondNumbersCount + 1)
            {
                secondNumbersCount = firstNumbersCount + 1;
                firstNumbersCount = 0;

                Console.WriteLine($"\nЧисло {array[i - 1]} повторяется {secondNumbersCount} раз(а).");

                secondNumbersCount = 0;
            }
        }

        if (firstNumbersCount == 0 && secondNumbersCount == 0)
            Console.WriteLine($"\nНет подмассива повторяющихся чисел.");
    }
}
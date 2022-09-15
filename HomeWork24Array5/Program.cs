internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 10;
        int number = 0;
        int numbersCount = 1;
        int maxNumbersCount = 1;
       
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
                numbersCount++;

                if (numbersCount > maxNumbersCount)
                {
                    maxNumbersCount = numbersCount;
                    number = array[i];
                }
            }
            else
            {
                numbersCount = 1;
            }
        }

        if (maxNumbersCount == 1)
            Console.WriteLine($"\nНет подмассива повторяющихся чисел.");
        else
            Console.WriteLine($"\nЧисло {number} повторяется {maxNumbersCount} раз(а).");
    }
}
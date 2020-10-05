using System;


namespace ReversingAnArray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);

        }

        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
            {
                
                numbers[index] = index + 1;
            }

            return numbers;
        }

        static int[] GenerateNumbers(int amount)
        {
            int[] numbers = new int[amount];

            for (int index = 0; index < amount; index++)
            {
                numbers[index] = index + 1;
            }

            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }

            Console.WriteLine();
        }

     
        static void Reverse(int[] numbers)
        {
            
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
               
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

      
                firstIndex++;
                secondIndex--;
            }
        }
    }
}

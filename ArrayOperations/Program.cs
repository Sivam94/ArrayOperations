using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 7, 3, 8, 6 };
            
            Console.WriteLine("Array before deletion is");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Deletion in an array

            int length = 7;
            int elementPosition = 7;

            while(elementPosition < length)
            {
                numbers[elementPosition - 1] = numbers[elementPosition]; //Assigns the value from an index to its previous index position
                elementPosition += 1;
            }
            
            length -= 1; //decreases the array length after deletion

            Console.WriteLine("Array after deletion is");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Searching in an array

            int elementToBeSearched = 7;

            for (int i = 0; i < length; i++)
            {
                if(numbers[i] == elementToBeSearched)
                {
                    Console.WriteLine("Element {0} is founded at position {1}", elementToBeSearched, i+1);
                    break;
                }
            }

            // Updating an element in an array

            int positionToBeUpdated = 5;
            int newNumber = 4;

            numbers[positionToBeUpdated - 1] = newNumber;

            Console.WriteLine("Array after updating the 6th element");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
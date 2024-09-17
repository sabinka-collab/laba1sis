internal class Program
{
    const int multipleOfThisNumber = 14, maxArrayLength = 1000, maxValueInArray = 10000;
    private static void Main(string[] args)
    {
        int[] array = new int[maxArrayLength];
        //array filling. 
        Random r = new();
        for (int i = 0; i < array.Length; i++)
            array[i] = r.Next(0, maxValueInArray);

        //find value in array 
        int max = 0, MultipleTwo = 0, MultipleSeven = 0, MultipleFourteen = 1, result = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max) max = array[i];

        foreach (int i in array)
        {
            if (i % multipleOfThisNumber == 0 && i > MultipleFourteen) MultipleFourteen = i;

            if (i % 2 == 0) MultipleTwo = i;

            if (i % 7 == 0) MultipleSeven = i;

            result = MultipleTwo * MultipleSeven;

            if (result == MultipleFourteen) break;
        }

        //output found element 
        if (result == MultipleFourteen && max == MultipleFourteen)
            Console.WriteLine($"{max} - это число соответсвует условиям задачи." +
            $"\nОно кратно 14, а также является произведением двух других различных элементов последовательности." +
            $"\nЭто: {MultipleTwo} и {MultipleSeven}");
        if (result != MultipleFourteen)
            Console.WriteLine(-1);
    }
}

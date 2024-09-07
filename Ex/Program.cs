public class Program
{

    //public class Ex3

    // שאלה 1
    // O(n + 1 + 1) = O(n)
    public static int CalcTheArr(int[] array)
    {
        int sum = 0;
        for (int number = 0; number < array.Length;)
        {
            if (array[number] % 2 == 1)
            {
                sum += array[number];
            }
        }
        return sum;
    }


    //שאלה 2
    // O(n + 1 + 1) = O(n)
    public static int[] FindMaximumTwo(int[] array)
    {
        int theMax = 0;
        int[] theMaxIndex = [array[0], array[1]];

        int sumTwo = 0;
        for (int number = 0; number < array.Length;)
        {
            sumTwo = array[number] + array[number + 1];
            if (sumTwo > theMax)
            {
                theMax = sumTwo;
                theMaxIndex = [array[number], array[number + 1]];
            }
        }
        return theMaxIndex;
    }


    // שאלה 3
    // O(n + 1) = O(n)
    public static bool ContainsNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length;)
        {
            if (array[i] == number)
                return true;
        }

        return false;
    }


    // שאלה 4
    // O(n**3 + 1) = O(n**3)
    public int SumOfAllTriplets(int[] array)
    {
        int result = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    int maxValue = array[i] + array[j] + array[k];
                    if (maxValue > result)
                    {
                        result = maxValue;
                    }
                }
            }
        }
        return result;
    }


    // שאלה 5
    // O(n - 1 + 1 + 1) = O(n) הוא לא עובר על הערך האחרון ולכן זה -1
    public int[] FindLastPairWithProduct(int[] array, int product)
    {
        int[] result = new int[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] * array[i + 1] == product)
            {
                result = new int[] { array[i], array[i + 1] };
            }
        }
        return result;
    }


    // שאלה 6
    // O(n + 1 + 1) = O(n)

    public int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }


    //// שאלה 7
    //// O(n + n + 2) = O(n)
    //public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
    //{
    //    int[] sortedArray = new int[array1.Length + array2.Length];
    //    int i = 0, j = 0;

    //    for (int k = 0; k < sortedArray.Length; k++)
    //    {
    //        if (array1[i] <= array2[j])
    //        {
    //            sortedArray[k] = array1[i];
    //            i++;
    //        }
    //        else if (array2[i] < array1[j])
    //        {
    //            sortedArray[k] = array2[j];
    //            j++;
    //        }
    //    }


    // for loop to get out the ununiqe numbers


    //    return sortedArray;
    //}





    //function to build

    // find last close pair with product o(n)

    // find last not close pair with product

    // שאלה 8
    //O(n**2 - 1 + 1) = O(n**2)
    public static void FindPairsWithSum(int[] array, int sum)
    { 
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1;j < array.Length ; j++)
            {
                if (array[i] + array[j] == sum)
                {
                    Console.WriteLine($"({array[i]}, {array[j]})");
                }
            }
        }
    }


    // שאלה 9
    // O(n + 1) = O(n)
    public Dictionary<int, int> CountFrequency(int[] array)
    {
        Dictionary<int, int> allNumbers = new Dictionary<int, int>();
        for(int i  = 0; i < array.Length; i++)
        {
            int number = array[i];
            if (allNumbers.ContainsKey(number))
            {
                allNumbers[number]++;
            }
            else
            {
                allNumbers[number] = 1;
            }
        }
        return allNumbers;
    }


    // שאלה 10
    // O()



    // שאלה 11
    // O()



    // שאלה 12
    // O()



    // שאלה 13
    // O()
}


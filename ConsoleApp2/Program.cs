// 1. write a function that creates an array of all of the odd numbers that are in an array

//int[] numbers = new int[] { 33, 44, 75, 81, 12, 101 };

//Console.WriteLine(String.Join(' ', GetOddNumbers(numbers)));

//int[] GetOddNumbers(int[] intArray)
//{
//    int[] oddNumArray = new int[1];

//    for (int i = 0; i < intArray.Length; i++)
//    {
//        if (intArray[i] % 2 == 1)
//        {
//            oddNumArray[oddNumArray.Length - 1] = intArray[i];

//            if (i != intArray.Length - 1)
//            {
//                Array.Resize(ref oddNumArray, oddNumArray.Length + 1);
//            }
//         }
//    }

//    return oddNumArray;
//}

// Write a function to check if a number is perfect (if it is the sum of its divisors. For example: 6 = 3 + 2 + 1(1 x 6 = 6, 2 x 3 = 6, 3 x 2 = 6)
// From Wikipedia: The first few perfect numbers are 6, 28, 496 and 8128
//int num = 100;

//Console.WriteLine(CheckForPerfectNumber(num));

//bool CheckForPerfectNumber(int number)
//{
//    int sum = 0;

//    for (int i = 1; i <= Math.Floor((double)(number / 2)); i++)
//    {
//        if (number % i == 0)
//        {
//            sum += i;
//        }
//    }

//    if (sum == number)
//    {
//        return true;
//    } else
//    {
//        return false;
//    }
//}

// Write a function for finding all duplicate values in an array, and returning all of those values in a new array.
//int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 2, 4, 7 };

//int[] newArray = FindDuplicates(intArray);

//for (int i = 0; i < newArray.Length; i++)
//{
//    Console.WriteLine(newArray[i]);
//}

//int[] FindDuplicates(int[] searchArray)
//{
//    int counter = 0;
//    int[] duplicates = new int[1];

//    if (searchArray == null || searchArray.Length == 1)
//    {
//        return new int[1] { 0 };
//    }

//    for (int i = 0; i < searchArray.Length; i++)
//    {
//        for (int j = i + 1; j < searchArray.Length; j++)
//        {
//            if (searchArray[i] == searchArray[j])
//            {
//                if (!Array.Exists(duplicates, element => element == searchArray[j]))
//                {
//                    duplicates[counter++] = searchArray[j];
//                    Array.Resize(ref duplicates, counter + 1);
//                }
//            }
//        }
//    }

//    Array.Resize(ref duplicates, counter);
//    return duplicates;
//}

// Create a method that will populate the previous function's array with user input until 0 is pressed (hint: you'll need the while method)
int[] intArray = populateArray();

int[] newArray = FindDuplicates(intArray);

for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}

int[] populateArray()
{
    int[] newArray = new int[1];
    int counter = 0;
    int userNumber = 0;

    do
    {
        Console.WriteLine("Enter a number. Enter 0 to end.");
        userNumber = Convert.ToInt32(Console.ReadLine());
        newArray[counter++] = userNumber;
        Array.Resize(ref newArray, counter + 1);
    } while (userNumber != 0);

    Array.Resize(ref newArray, counter - 1);
    return newArray;
}

int[] FindDuplicates(int[] searchArray)
{
    int counter = 0;
    int[] duplicates = new int[1];

    if (searchArray == null || searchArray.Length == 1)
    {
        return new int[1] { 0 };
    }

    for (int i = 0; i < searchArray.Length; i++)
    {
        for (int j = i + 1; j < searchArray.Length; j++)
        {
            if (searchArray[i] == searchArray[j])
            {
                if (!Array.Exists(duplicates, element => element == searchArray[j]))
                {
                    duplicates[counter++] = searchArray[j];
                    Array.Resize(ref duplicates, counter + 1);
                }
            }
        }
    }

    Array.Resize(ref duplicates, counter);
    return duplicates;
}





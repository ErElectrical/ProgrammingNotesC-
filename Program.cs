using System;

namespace ArrayClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Array tutorial");
            //An array is a group of like-typed variables that are referred to by a common name.
            //And each data item is called an element of the array.
            //The data types of the elements may be any valid data type like char, int, float, etc.
            //and the elements are stored in a contiguous location.
            //Length of the array specifies the number of elements present in the array.
            //In C# the allocation of memory for the arrays is done dynamically.
            //And arrays are kinds of objects,
            //therefore it is easy to find their size using the predefined functions.
            //The variables in the array are ordered and each has an index beginning from 0.

            //Array Declaration

            //Syntax:

            //< Data Type > [ ] < Name_Array >
            //Here,
            //< Data Type > : It define the element type of the array.
            //[ ] : It define the size of the array.
            //< Name_Array > : It is the Name of array.

            //Example:

            //int[] x;  // can store int values
            //string[] s; // can store string values
            //double[] d; // can store double values
            //Student[] stud1; // can store instances of Student class which is custom class


            //Decleartion of array alone can not make it dynamic 
            //first we have to initialise it 

            //Array Initialization

            //            As said earlier, an array is a reference type so the new keyword used to create an instance of the array.
            //            We can assign initialize individual array elements, with the help of the index.

            //Syntax:
            // type [ ] < Name_Array > = new < datatype > [size];

            //  Here, type specifies the type of data being allocated,
            //  size specifies the number of elements in the array,
            //  and Name_Array is the name of an array variable.
            //  And new will allocate memory to an array according to its size.

            // Examples : To Show Different ways for the Array Declaration and Initialization

            //Example 1 :
            //// defining array with size 5. 
            //// But not assigns values
            //int[] intArray1 = new int[5];
            //The above statement declares & initializes int type array that can store five int values.
            //The array size is specified in square brackets([]).

            //Example 2 :

            //// defining array with size 5 and assigning
            //// values at the same time
            //int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };
            // The above statement is the same as, but it assigns values to each index in { }.

            //Example 3 :
            //// defining array with 5 elements which 
            //// indicates the size of an array
            //  int[] intArray3 = { 1, 2, 3, 4, 5 };
            // In the above statement, the value of the array is directly initialized without taking its size.
            // So, array size will automatically be the number of values which is directly taken.

            //Initialization of an Array after Declaration

            //Arrays can be initialized after the declaration.
            //It is not necessary to declare and initialize at the same time using the new keyword.
            //However, Initializing an Array after the declaration, it must be initialized with the new keyword.
            //It can’t be initialized by only assigning values.




            //Example :

            //// Declaration of the array
            //string[] str1, str2;

            //// Initialization of array
            //   str1 = new string[5] { “Element 1”, “Element 2”, “Element 3”, “Element 4”, “Element 5” };

            //   str2 = new string[5] { “Element 1”, “Element 2”, “Element 3”, “Element 4”, “Element 5” };

            //   Note: Initialization without giving size is not valid in C#. It will give a compile-time error.

            //Example : Wrong Declaration for initializing an array

            //// compile-time error: must give size of an array
            //int[] intArray = new int[];

            // error : wrong initialization of an array
            // string[] str1;
            // str1 = {“Element 1”, “Element 2”, “Element 3”, “Element 4” };

            // Accessing Array Elements

            // At the time of initialization,
            // we can assign the value.
            // But, we can also assign the value of the array using its index
            // randomly after the declaration and initialization.
            // We can access an array value through indexing,
            // placed index of the element within square brackets with the array name
            // Example:


            ////declares & initializes int type array
            //int[] intArray = new int[5];

            //            // assign the value 10 in array on its index 0
            //            intArray[0] = 10;

            //            // assign the value 30 in array on its index 2
            //            intArray[2] = 30;

            //            // assign the value 20 in array on its index 1
            //            intArray[1] = 20;

            //            // assign the value 50 in array on its index 4
            //            intArray[4] = 50;

            //            // assign the value 40 in array on its index 3
            //            intArray[3] = 40;

            //            // Accessing array elements using index
            //            intArray[0];  //returns 10
            //            intArray[2];  //returns 30

            string[] str;
            str = new string[] { "a", "Ss", "fd", "fg" };

            Console.WriteLine("for loop");
            for (int i = 0;i<str.Length; i++)
            {
                Console.Write("  " + str[i]);
            }

            Console.WriteLine(" ");

            Console.Write("For-each loop :");

            // using for-each loop
            foreach (string i in str)
                Console.Write(" " + i);

            Console.WriteLine(" ");


            Console.Write("while loop :");

            // using while loop
            int j = 0;
            while (j < str.Length)
            {
                Console.Write(" " + str[j]);
                j++;
            }

            Console.WriteLine(" ");

            // using do -while loop

            int k = 0;
            do
            {
                Console.Write(" " + str[k]);
                k++;
            } while (k < str.Length);

            //Multidimensional Arrays

            //The multi-dimensional array contains more than one row to store the values.
            //It is also known as a Rectangular Array in C# because it’s each row length is same.
            //It can be a 2D-array or 3D-array or more.
            //To storing and accessing the values of the array, one required the nested loop.
            //The multi-dimensional array declaration, initialization and accessing is as follows :

            // creates a two-dimensional array of 
            // four rows and two columns.
            //int[,] intarray = new int[4, 2];

            //creates an array of three dimensions, 4, 2, and 3
            // int[,,] intarray1 = new int[4, 2, 3];

            // Two-dimensional array
            int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };

            // The same array with dimensions 
            // specified 4 row and 2 column.
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };

            // A similar array with string elements.
            string[,] strn = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

            // Three-dimensional array.
            int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };

            // The same array with dimensions 
            // specified 2, 2 and 3.
            int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                { 10, 11, 12 } } };

            // using nested loop show string elements
            Console.WriteLine("To String element");
            for (int i = 0; i < 4; i++)
                for (int nm = 0; nm < 2; nm++)
                    Console.Write(strn[i, j] + " ");


            //Jagged Arrays

            // An array whose elements are arrays is known as Jagged arrays it means “array of arrays“.
            // The jagged array elements may be of different dimensions and sizes.
            //
            // 

            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Another way of Declare and
            // Initialize of elements
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                         new int[] { 2, 4, 6, 8 } };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int jkm = 0; jkm < arr[i].Length; jkm++)
                    Console.Write(arr[i][jkm] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Another Array");

            // Display the another array elements:
            for (int i = 0; i < arr1.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int jk = 0; jk < arr1[i].Length; jk++)
                    Console.Write(arr1[i][jk] + " ");
                Console.WriteLine();
            }

        }
    }
}
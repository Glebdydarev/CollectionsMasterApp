﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] array = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array);

            //Print the first number of the array
            Console.WriteLine(array[0]);


            //Print the last number of the array
            Console.WriteLine(array[array.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */


            Console.WriteLine("All Numbers Reversed:");
            var numbersReverse = array.Reverse();

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);


            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array);
            NumberPrinter(array);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList = new List<int>();


            //Print the capacity of the list to the console

            Console.WriteLine($"Capacity is: {numList.Capacity}");


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this

            Populater(numList);
            NumberPrinter(numList);

            //Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isANumber == false);

            NumberChecker(numList, userNumber);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();


            //Clear the list

            numList.Clear();
            Console.WriteLine("List cleared");
            #endregion
        }

        private static void NumberChecker(List<int> numList, int userNumber)
        {
            if (numList.Contains(userNumber))
                Console.WriteLine("Yes we have the number you're looking for.");
            else
            {
                Console.WriteLine("No that is NOT in teh list.");
            }
        }

        private static void Populater(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random rng = new Random();
                array[i] = rng.Next(0, 50);
            }
        }

        private static void Populater(List<int> numList)
        {
            Random rng = new Random();
            while (numList.Count <= 50)
            {
                var number = rng.Next(0, 50);
                numList.Add(number);

            }
        }

        /*private static void NumberPrinter(List<int> numList)
        {
            throw new NotImplementedException();
        }

        private static void NumberPrinter(int[] array)
        {
            throw new NotImplementedException();
        }
        */
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }


        private static void OddKiller(List<int> numberList)
        {
            for (var i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)

                {
                    numberList.Remove(numberList[i]);

                }
            }
        }

                

                


                /// <summary>
                /// Generic print method will iterate over any collection that implements IEnumerable<T>
                /// </summary>
                /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
                /// <param name="collection"></param>
                private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
                {
                    //STAY OUT DO NOT MODIFY!!
                    foreach (var item in collection)
                    {
                        Console.WriteLine(item);
                    }
                }
            
        

        
        
          
        
    }
}
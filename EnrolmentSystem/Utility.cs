﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Utility
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LinearSearch<T>(T[] array, T target) where T : IComparable<T>
        {

            int i = 0;
            bool found = false;
            while (!found && i < array.Length) // while not found and not end of array 
            {
                if (target.CompareTo(array[i]) == 0)
                    found = true;
                  
                else
                    i++; // if no match move to next element in array 
            }

            if (i < array.Length)
                return i; //return index of array element found 

            else

                return -1; //return -1 if not found. 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                if (array[mid].CompareTo(target) == 0)  //if the item is found return the index mid
                    return mid;
                if (array[mid].CompareTo(target) == -1)  //check if the item wanted is in the top half of the search 
                    min = mid + 1; //the item must be in the upper half, set the min for the search to start at mid +1
                else
                    max = mid - 1; //otherwise the item must be in the lower half, set max to the mid-1
            } while (min <= max);
            return -1;  // -1 is returned when not found
        }

        //Object of Type <T> in ascending order 
        public static void BubbleSort_Ascending<T>(T[] array) where T : IComparable<T>
        {

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        // Swap array[j] with array[j + 1]
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

            //Object of Type <T> in descending order 
    public static void BubbleSort_Descending<T>(T[] array) where T : IComparable<T>
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare the current element with the next element
                if (array[j].CompareTo(array[j + 1]) < 0)
                {
                    // Swap array[j] with array[j + 1]
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    }

}

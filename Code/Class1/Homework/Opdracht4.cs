﻿/*
 *  Geef een voorbeeld van een binary search in een int-array
 */

using System;

namespace ADS.Class1.Homework
{
    /*
     * For more information about this algorithm see ListeningClass.BinarySearch.cs
     */
    class Opdracht4
    {
        public void Run()
        {
            int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            int key = 7;

            Console.WriteLine("Key {0} is at position {1} in the array", key, BinarySearch(ints, key));

            
        }

        private int BinarySearch(int[] ints, int key)
        {
            int lowest = 0;
            int highest = ints.Length - 1;

            while (lowest <= highest)
            {
                int center = lowest + (highest - lowest) / 2;

                if (key < ints[center])
                {
                    highest = center - 1;
                }
                else
                {
                    if (key > ints[center])
                    {
                        lowest = center + 1;
                    }
                    else
                    {
                        return center;
                    }
                }
            }

            return -1;
        }
    }
}

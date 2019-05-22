﻿using System;


namespace functionsSchoolStuff
{
    class MyMath
    {
        public static double Stiya(int[] values)
        {
            //שאלה 6 עם הרחבה בעזרת אבא
            int sumOfNumbers = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sumOfNumbers = sumOfNumbers + values[i];
            }
            double avg = sumOfNumbers / values.Length;
            double sumTopLine = 0;
            for (int j = 0; j < values.Length; j++)
            {
                sumTopLine = sumTopLine + Math.Pow(values[j] - avg, 2);
            }
            double insideSQRT = sumTopLine / values.Length;
            return Math.Sqrt(insideSQRT);
        }

        public static double Average(int[] values)
        {
            int sumOfNumbers = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sumOfNumbers = sumOfNumbers + values[i];
            }
            return sumOfNumbers / values.Length;
        }

        
        public static int[] NegativeThenPositive(int[] array) // divides array to all negative values then all positive values
        {
            int[] toReturn = new int[array.Length];
            int positiveIndex = 0;
            for (int i = 0; i < toReturn.Length; i++)
            {
                if (array[i] < 0)
                {
                    toReturn[i - positiveIndex] = array[i];
                }
                else if (array[i] >= 0)
                {
                    toReturn[toReturn.Length - positiveIndex - 1] = array[i];
                    positiveIndex++;
                }
            }
            return toReturn;
        }

        public static int[] MergeIncreasingArrays(int[] arr1, int[] arr2)
        {
            int[] merged = new int[arr1.Length + arr2.Length];
            int indexArr1 = 0, indexArr2 = 0;
            int i = 0;
            while (indexArr1 < arr1.Length - 1 && indexArr2 < arr2.Length - 1)
            {
                if (arr1[indexArr1] < arr2[indexArr2])
                {
                    merged[i] = arr1[indexArr1];
                    indexArr1++;
                }
                else if (arr1[indexArr1] > arr2[indexArr2])
                {
                    merged[i] = arr2[indexArr2];
                    indexArr2++;
                }
                else
                {
                    merged[i] = arr1[indexArr1];
                    indexArr1++;
                }
                i++;
            }
            if (indexArr1 == arr1.Length - 1)
            {
                for (int j = indexArr2; j < arr2.Length; j++)
                {
                    merged[j + i] = arr2[j];
                }
            }
            else if (indexArr2 == arr2.Length - 1)
            {
                for (int j = indexArr1; j < arr1.Length; j++)
                {
                    merged[j + i] = arr1[j];
                }
            }
            return merged;
        }

        public static bool IsEachNumOnce (int[] array)
        {
            bool eachNumOnce = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j != i && array[j] == array[i])
                    {
                        eachNumOnce = false;
                    }
                }
            }
            return eachNumOnce;
        }
    }
}
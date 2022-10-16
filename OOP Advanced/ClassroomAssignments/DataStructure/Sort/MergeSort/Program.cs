using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;   
  
namespace MergeSort    
{    
    class nProgram    
    {    
        static public void MainMerge(int[] numbers, int left, int mid, int right)    
        {    
            int[] temp = new int[25];    
            int i, eol, num, pos;    
            eol = (mid - 1);    
            pos = left;   
            num = (right - left + 1);     
  
            while ((left <= eol) && (mid <= right))    
            {    
                if (numbers[left] <= numbers[mid])    
                    temp[pos++] = numbers[left++];    
                else    
                    temp[pos++] = numbers[mid++];    
            }    
            while (left <= eol)    
                temp[pos++] = numbers[left++];    
            while (mid <= right)    
                temp[pos++] = numbers[mid++];   
            for (i = 0; i < num; i++)    
            {    
                numbers[right] = temp[right];    
                right--;    
            }    
        }   
  
        static public void SortMerge(int[] numbers, int left, int right)    
        {    
            int mid;    
            if (right > left)    
            {    
                mid = (right + left) / 2;    
                SortMerge(numbers, left, mid);    
                SortMerge(numbers, (mid + 1), right);    
                MainMerge(numbers, left, (mid + 1), right);    
            }    
        }     
  
        static void Main(string[] args)    
        {    
  
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");    
            int[] numbers = new int[]{18,19,1,5,7,3,20};    
            Console.Write("Input int array : ");    
            Console.Write("\n");    
            for (int k = 0; k < numbers.Length; k++)    
            {    
                Console.Write(numbers[k] + " ");       
            }    
            Console.WriteLine("MergeSort By Recursive Method");    
            SortMerge(numbers, 0, numbers.Length- 1);    
            for (int i = 0; i < numbers.Length; i++)    
                Console.WriteLine(numbers[i]);    
            Console.ReadLine();    
        }    
    }    
}
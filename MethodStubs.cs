using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_MethodStubs
{
    class MethodStubs
    {
        //Write a method that takes two integers and displays their sum.
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        //Write a method that takes five doubles and returns their average.
        public double AverageDouble(double doub1, double doub2, double doub3, double doub4, double doub5)
        {
            return (doub1 + doub2 + doub3 + doub4 + doub5) / 5;
        }
        //Write a method that returns the sum of two randomly generated integers.
       
        public int RandomIntSum()
        {
            Random numGenerator = new Random();
            int random1 = numGenerator.Next();
            int random2 = numGenerator.Next();
            return random1 + random2;            
        }
        //Write a method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
        public bool DivisibleByThree(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) % 3 == 0; //alternatively, an if/else return true or false            
        }
        //Write a method that takes two strings and displays the string that has fewer characters.
        public string LesserString(string string1, string string2)
        {
            if (string1.Length > string2.Length)
            {
                return string2;
            }
            else
            {
                return string1;
            }
        }
        //Write a method that takes an array of doubles and returns the largest value in the array.
        public double LargestDouble(double[] doubleArray)
        {
            double largestDouble = 0.0;
            for(int index = 0; index < doubleArray.Length; index++)
            {
                if(doubleArray[index] > largestDouble)
                {
                    largestDouble = doubleArray[index];
                }
            }
            return largestDouble;
        }
        //Write a method that generates and returns an array of fifty integer values.
        public int[] GenerateIntegerArray()
        {
            int[] arrayOfIntegers = new int[50];

            Random intGenerator = new Random();
            for (int index = 0; index < 50; index++)
            {
                int randomInteger = intGenerator.Next();
                arrayOfIntegers[index] = randomInteger;
            }
            return arrayOfIntegers;
        }
        //Write a method that takes two bool variables and returns true if they have the same value, false otherwise.
        public bool BooleanCompare(bool bool1, bool bool2)
        {
            return (bool1 == bool2);
        }
        //Write a method that takes an int and a double and returns their product.
        public double ProductIntDouble(int int1, double doub1)
        {
            return int1 * doub1;
        }
        //Write a method that takes a two-dimensional array of integers and returns the average of the entries.
        public double Average2DArray(int[,] a2DArray)
        {
            int rows = a2DArray.GetLength(0);// gets the number of rows in the entered multidimensional array
            int columns = a2DArray.GetLength(1);// gets the number of columns in the entered multidimensional array
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("Columns: " + columns);

            int sumOfEntries = 0;//this is my accumulator
            
            
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < columns; col++)
                {
                    sumOfEntries += a2DArray[row, col];
                }
            }
            double average = ((double)sumOfEntries) / (rows * columns); 
            return average;
        }
    }


}
